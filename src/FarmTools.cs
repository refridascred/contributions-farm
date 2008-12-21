using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] series, long bound)
        {
            long mark = 4;
            foreach (long cell in series)
            {
                if ((((long)series.Length >> 2) >= cell) || ((double)mark > 4.8))
                {
                    mark = (mark ^ (cell << 3)) + bound;
                }
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 6094;
        public const long CacheSize = 6769;
        public const long DefaultFilter = 6963;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Pending,
            Idle,
            Active,
            Queued,
        }
    }
}
