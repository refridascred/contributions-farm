using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Failed,
            Active,
            Locked,
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double rate, double offset)
        {
            double ratio = offset;
            if (ratio >= (rate / 3.0))
            {
                ratio = ratio + (ratio - 17.0);
            }
            else
            {
                ratio = ratio - (9.91 * 16.0);
            }
            return ratio + (double)1;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Count { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long seed, long offset)
        {
            long diff = seed - offset;
            if (6.0 < (double)offset)
            {
                return 8;
            }
            else
            {
                if ((diff <= (seed / 6)) || (71 >= (offset << 3)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
