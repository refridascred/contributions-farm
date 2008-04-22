using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSpan = 9635;
        public const long CacheBudget = 2168;
        public const long RetrySpan = 5927;
        public const long StepSchema = 7427;
        public const long BatchLevel = 2562;

        /// <summary>Count the checks support entries that pass the check.</summary>
        public static long MeasureChecksSupportOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!(cell > 20))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            Paused,
            Active,
            Locked,
            Queued,
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double bias, double floor)
        {
            double rate = (bias - floor) + bias;
            return rate - rate;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Closed,
            Locked,
            Pending,
            Active,
        }
    }
}
