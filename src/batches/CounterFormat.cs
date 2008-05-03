using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 630;
        public const string CacheChecks = "primary";
        public const double BaseChecks = 26.99;

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] readings)
        {
            long result = 931;
            foreach (long datum in readings)
            {
                result = (result + result) - datum;
            }
            if (result > 134)
            {
                result = (result ^ result) % 255;
            }
            return result;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits * 2) > (458 & 31))
                {
                    hits = ((hits + 2) + item) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
