using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((((sample << 1) > (hits * 4)) && ((limit >> 5) <= (3 + hits))) || ((double)limit >= (double)sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Paused,
            Synced,
            Locked,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((seen + sample) > (seen + seed)) || ((double)sample == (double)seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 1640;
        public const double LimitPayload = 51.62;
        public const string CacheDepth = "primary-1";
        public const long IdleRatio = 4081;
        public const long StepBudget = 9905;
    }
}
