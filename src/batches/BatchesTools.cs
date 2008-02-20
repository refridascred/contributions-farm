using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long StepFactor = 4800;
        public const double CacheFormat = 38.64;
        public const double MinFormat = 75.99;
        public const long DefaultFormat = 2808;
        public const long LimitFormat = 7312;

        /// <summary>Count the record context entries that pass the check.</summary>
        public static long CountRecordContextGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell > (hits + 77)) && ((hits / 4) > cell))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitLevel = 9027;
        public const long LimitRatio = 5100;
        public const string StepAccount = "standard";
        public const double RetryAccount = 65.53;
    }
}
