﻿using System;

namespace Leaf.Net
{
    /// <summary>
    /// Представляет данные для события, сообщающим о прогрессе выгрузки данных.
    /// </summary>
    public sealed class UploadProgressChangedEventArgs : EventArgs
    {
        #region Свойства (открытые)

        /// <summary>
        /// Возвращает количество отправленных байтов.
        /// </summary>
        public long BytesSent { get; }

        /// <summary>
        /// Возвращает общее количество отправляемых байтов.
        /// </summary>
        public long TotalBytesToSend { get; }

        /// <summary>
        /// Возвращает процент отправленных байтов.
        /// </summary>
        public double ProgressPercentage => ((double)BytesSent / TotalBytesToSend) * 100.0;

        #endregion


        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="UploadProgressChangedEventArgs"/>.
        /// </summary>
        /// <param name="bytesSent">Количество отправленных байтов.</param>
        /// <param name="totalBytesToSend">Общее количество отправляемых байтов.</param>
        public UploadProgressChangedEventArgs(long bytesSent, long totalBytesToSend)
        {
            BytesSent = bytesSent;
            TotalBytesToSend = totalBytesToSend;
        }
    }
}
