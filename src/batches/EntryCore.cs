using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Done,
            Synced,
            Stale,
            Failed,
        }

        /// <summary>Audit route order readings against a rule.</summary>
        public static long TallyRouteOrderMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((bound << 3) <= 24)
                {
                    hits = (hits + 3) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepRatio = 9474;
        public const string CacheBatch = "primary-1";
        public const string MaxRatio = "legacy-v2";
        public const long DefaultBatch = 2398;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Paused,
            Idle,
        }
    }
}
