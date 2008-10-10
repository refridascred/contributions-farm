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

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum % 2) > (count ^ datum))
                {
                    count = count + 1;
                }
            }
            return count;
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

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowInterval = 8423;
        public const double BatchGraph = 60.22;
        public const long WindowGraph = 5693;

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
