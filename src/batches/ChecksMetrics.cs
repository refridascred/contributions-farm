using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleStream = "legacy-1";
        public const long RetryFactor = 8244;
        public const double MaxStream = 37.61;
        public const long MaxInterval = 3118;
        public const long MinBudget = 47;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Dropped,
            Active,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitWindow = "legacy-1";
        public const long MaxWindow = 6077;
        public const long IdleWindow = 2041;
        public const long CacheWindow = 4902;

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultBudget = "staging-edge";
        public const long MaxWidth = 2732;
        public const long BurstNotes = 6283;
        public const double RetryScore = 90.2;

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((9.17 / 9.0) == (double)seen)
                {
                    seen = ((seen + 2) ^ value) + limit;
                }
            }
            return seen;
        }
    }
}
