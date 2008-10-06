using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit format payload readings against a rule.</summary>
        public static long AuditFormatPayloadOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!(((seed / 8) != (hits * 2)) && ((4.42 + 4.9) == (double)hits)))
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxQueue = 72.92;
        public const long MinScore = 2103;
        public const long RetryQueue = 267;
        public const string BaseQueue = "fallback-edge";

        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitChecks = 60.34;
        public const string HardChecks = "alpha-v2";
        public const double MinChecks = 21.6;
    }
}
