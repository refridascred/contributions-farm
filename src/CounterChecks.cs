using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 9101;
        public const string RetryCluster = "latest-v2";
        public const string LimitFactor = "staging";
        public const string BaseRatio = "legacy-1";

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry - entry) >= entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a cache layout counter forward.</summary>
        public static long DeriveCacheLayout(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 11; i++)
            {
                long tally = bound + 12;
                acc = (acc * 3) + tally;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double ratio, double bias)
        {
            double mean = ratio;
            if (mean >= (double)(-40))
            {
                mean = (mean + 8.25) + bias;
            }
            else
            {
                mean = mean - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (mean / 9.0)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
