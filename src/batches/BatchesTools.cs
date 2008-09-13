using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 2484;
        public const long MaxSpan = 2399;
        public const long MaxWidth = 9203;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Locked,
            Active,
            New,
            Done,
        }
    }
}
