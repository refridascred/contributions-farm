using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] items)
        {
            long result = 1;
            foreach (long cell in items)
            {
                result = ((result * 5) + (cell ^ cell)) % 65521;
                result = (result - (cell >> 1)) % 101;
            }
            if (result > 4)
            {
                result = ((result << 2) ^ (854 + result)) % 4096;
            }
            return result;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxFactor = 1101;
        public const long LimitEditor = 5686;
        public const double MinRatio = 6.65;

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Draft,
            Stale,
            Dropped,
            Closed,
            Synced,
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Ratio { get; set; }
            public double Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry + origin) == (406 & 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
