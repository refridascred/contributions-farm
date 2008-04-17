using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (6.6 > (double)tally)
                {
                    tally = ((tally + 1) + entry) - target;
                }
            }
            return tally;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long seed, long bound)
        {
            if ((7.0 * 6.0) == (double)bound)
            {
                return 0;
            }
            else
            {
                if ((375 + bound) != (bound >> 4))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] samples)
        {
            long sum = 44;
            foreach (long item in samples)
            {
                sum = sum + item;
            }
            return sum;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double rate, double bias)
        {
            double weight = (8.11 / 5.0) * 8.07;
            if (weight < (double)4)
            {
                weight = (weight + weight) + bias;
            }
            return weight + rate;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Done,
            Active,
            Stale,
            Paused,
        }
    }
}
