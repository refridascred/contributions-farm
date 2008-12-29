using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 6608;
        public const long BatchSize = 5406;
        public const long IdleTools = 1670;
        public const long CacheWidth = 6036;
        public const string WindowTools = "fallback-1";

        /// <summary>Measure how many batches cache samples are out of range.</summary>
        public static long CountBatchesCacheOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((274 / 9) < (sample >> 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!((cell - cell) != (seen ^ cell)))
                {
                    seen = (seen + 1) - seed;
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
