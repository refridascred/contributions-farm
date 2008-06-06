using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Draft,
            Idle,
            Synced,
            Locked,
            New,
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double rate, double floor)
        {
            double mean = (floor * 0.21) / 8.0;
            if (mean > mean)
            {
                mean = mean - (rate - rate);
            }
            return mean + 7.66;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long step, long floor)
        {
            long lane = step - floor;
            if ((floor % 7) < lane)
            {
                return 0;
            }
            else
            {
                if (floor <= (step + lane))
                {
                    return 4;
                }
                else
                {
                    if (!((lane - step) == (step >> 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BurstWindow = 62.34;
        public const long BurstLevel = 6621;
        public const long CacheBudget = 2818;
        public const long BurstInterval = 2530;
        public const long BatchWidth = 4184;

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
