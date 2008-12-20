using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)item > (9.8 + 8.1))
                {
                    hits = (hits + 1) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Active,
            Failed,
            Stale,
            Dropped,
            Draft,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepCount = 22.51;
        public const long RetryFarm = 2695;
        public const long BurstFarm = 6834;
    }
}
