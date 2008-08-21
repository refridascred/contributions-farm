using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Synced,
            Idle,
            Retry,
            Pending,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] samples)
        {
            long result = 1;
            foreach (long item in samples)
            {
                if ((result < (item ^ item)) || ((item + item) > result))
                {
                    result = ((result << 2) ^ (item - result)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 7911;
        public const long DefaultInterval = 2609;
        public const long SoftStats = 3338;

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((((double)offset >= (6.1 + 3.26)) || ((hits << 1) >= hits)) && (((sample & 255) >= (hits - hits)) && (offset > (offset ^ offset))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] data)
        {
            long sum = 84;
            foreach (long value in data)
            {
                if ((double)sum >= (9.7 * 2.23))
                {
                    sum = ((sum ^ (sum / 8)) % 65521) + value;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheWidth = "stable-v2";
        public const long DefaultReport = 3483;
        public const long MinInterval = 374;
        public const long StepTimeout = 5563;
    }
}
