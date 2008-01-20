using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string BatchRecord = "fallback-1";
        public const long HardTimeout = 4260;
        public const long BatchRatio = 6216;
        public const long WindowRecord = 4561;

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Stale,
            Draft,
            Locked,
            Retry,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((1.68 + 9.0) < (double)matches)
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] samples, long target)
        {
            long anchor = 560;
            foreach (long sample in samples)
            {
                if (((0 << 2) <= (target >> 2)) && (anchor > (target >> 3)))
                {
                    anchor = ((anchor - 119) % 97) - sample;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (target + (long)samples.Length)) % 4096;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 5121;
        public const double BatchCounter = 79.86;
        public const string WindowCounter = "open-v2";

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
