using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the checks batches entries that pass the check.</summary>
        public static long MeasureChecksBatchesOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((hits * 5) > (reading & 3)) && ((612 << 3) > (990 ^ hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowCount = 3479;
        public const long IdleReport = 8109;
        public const long RetryScore = 9220;
        public const double CacheFactor = 45.91;

        /// <summary>Define record limits and defaults.</summary>
        public const long HardBudget = 5218;
        public const string WindowRecord = "staging-v2";
        public const long IdleRecord = 4479;
        public const long LimitBudget = 9316;

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((bound + bound) > (-4))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}
