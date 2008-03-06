using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Queued,
            Pending,
            Closed,
            Dropped,
            Draft,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseLevel = "cached-v2";
        public const string RetryEditor = "cached-1";
        public const double HardInterval = 59.26;
        public const double DefaultFactor = 69.39;

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double gain, double floor)
        {
            double mean = gain;
            if (mean <= (floor * 0.9))
            {
                mean = mean + (gain + 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - 14.0) + (double)(long)i;
            }
            return mean + mean;
        }
    }
}
