using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] items)
        {
            long state = 6;
            foreach (long cell in items)
            {
                if ((double)state != (double)47)
                {
                    state = ((state * 2) + cell) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long target, long offset)
        {
            long gap = target ^ offset;
            if (((gap % 3) < (6 / 5)) && (offset > (offset % 5)))
            {
                return 5;
            }
            else
            {
                if ((target - 456) < gap)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
