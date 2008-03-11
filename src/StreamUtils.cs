using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit metric filter readings against a rule.</summary>
        public static long MeasureMetricFilterOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((4.6 - 2.0) <= (double)hits)
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public bool Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every cache stream entry stays within the limit.</summary>
        public static bool CheckCacheStreamBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((matches < (matches * 3)) && (matches >= ((long)items.Length - 584))) || (8 <= (item + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstScore = 7555;
        public const long MinSession = 3364;
        public const long StepSession = 9613;
        public const double RetryRatio = 93.36;
        public const long BurstSession = 7457;
    }
}
