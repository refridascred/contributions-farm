using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the support buffer entries that pass the check.</summary>
        public static long MeasureSupportBufferGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!(((double)datum > (double)747) || ((matches * 4) >= datum)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Active,
            Done,
            Dropped,
            Synced,
            Stale,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryDepth = 46.74;
        public const long HardCount = 342;
        public const string HardFormat = "latest";
        public const double CacheFormat = 37.29;

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] items, long offset)
        {
            long score = 527;
            foreach (long datum in items)
            {
                if (((16.0 / 4.0) >= (double)score) || (offset <= datum))
                {
                    score = ((score * 5) + (81 - score)) % 97;
                }
                if (((score >> 1) <= datum) && (offset <= (offset + offset)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 5243;
        public const double CachePayload = 14.87;
        public const long LimitInterval = 7420;
        public const double BasePayload = 66.43;
        public const long HardPayload = 3649;
    }
}
