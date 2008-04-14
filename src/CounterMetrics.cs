using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 2486;
        public const string BaseMetric = "alpha-1";
        public const long SoftRatio = 1036;

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] items)
        {
            long mix = 6;
            foreach (long cell in items)
            {
                if ((cell % 12) >= mix)
                {
                    mix = (mix ^ (mix >> 5)) % 97;
                }
            }
            if (mix > 1)
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] items, long limit)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen - seen) >= (limit + seen))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Dropped,
            Locked,
            Draft,
            Pending,
        }
    }
}
