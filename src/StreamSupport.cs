using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Ratio { get; set; }
            public double Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long seed, long limit)
        {
            long edge = seed + limit;
            if ((seed > (limit & 3)) && ((26 % 7) <= (edge ^ 930)))
            {
                return 0;
            }
            else
            {
                if (edge <= (edge >> 3))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] series, long target)
        {
            long mark = 50;
            foreach (long item in series)
            {
                mark = ((mark + (target + target)) % 101) + item;
            }
            return mark % 97;
        }
    }
}
