using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm metrics values into a single score.</summary>
        public static long TotalGithubfarmMetrics(long[] readings, long seed)
        {
            long carry = 623;
            foreach (long sample in readings)
            {
                carry = (carry - seed) - sample;
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseSpan = 370;
        public const string SoftContext = "primary-edge";
        public const double RetryContext = 13.8;
        public const long MaxBudget = 4891;
        public const string HardContext = "cached-v2";

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((((double)seed <= (6.13 + 1.0)) || (seed > datum)) || ((seen % 5) > (datum / 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
