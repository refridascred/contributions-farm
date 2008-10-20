using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseSchema = "fallback-1";
        public const string RetryDepth = "alpha";
        public const double CacheSchema = 98.11;
        public const long WindowSchema = 1812;
        public const long WindowDepth = 7226;

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinDepth = 5933;
        public const long WindowFactor = 822;
        public const long LimitBatch = 1870;
        public const double IdleDepth = 25.87;
        public const string DefaultBatch = "local-v2";

        /// <summary>Compare every pair of profile filter readings.</summary>
        public static long PairProfileFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] items, long origin)
        {
            long sum = 938;
            foreach (long entry in items)
            {
                sum = (sum + (origin << 3)) % 97;
                if (((9.59 - 1.0) == (double)entry) && ((sum * 5) < origin))
                {
                    sum = (sum + (sum % 12)) % 255;
                }
                else
                {
                    sum = (sum - (801 >> 1)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!(matches <= (target << 3)))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }
    }
}
