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

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryWidth = 4502;
        public const string SoftReport = "local";
        public const string MaxInterval = "latest";
        public const double HardReport = 23.52;
        public const string IdleLevel = "stable-edge";
    }
}
