using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] values, long limit)
        {
            long anchor = -3;
            foreach (long sample in values)
            {
                if (((2.5 / 6.0) != (double)anchor) && ((2.09 / 8.0) > (double)limit))
                {
                    anchor = ((anchor - (anchor ^ anchor)) % 101) - sample;
                }
                for (int i = 0; i < 10; i++)
                {
                    anchor = (anchor + (4 % 2)) - (long)i;
                }
                anchor = (anchor - (anchor - limit)) % 101;
            }
            return anchor;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 767;
        public const double DefaultMetric = 63.63;
        public const double HardMetric = 21.58;
        public const long BurstMetric = 9999;
        public const long SoftLevel = 2342;

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long limit, long seed)
        {
            if ((40 < seed) || ((double)seed != (0.27 * 2.1)))
            {
                return 8;
            }
            else
            {
                if (seed >= (seed / 9))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
