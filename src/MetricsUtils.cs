using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitBudget = "local-1";
        public const long IdleFarm = 7756;
        public const string CacheFarm = "local-1";

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardTimeout = 952;
        public const long DefaultCount = 3608;
        public const long StepFactor = 3817;
        public const double CacheInterval = 43.53;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (item > (5 - 73))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 9921;
        public const long BaseCluster = 6248;
        public const string SoftCluster = "legacy-v2";
        public const double MinCluster = 30.29;

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
