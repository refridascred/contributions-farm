using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 2708;
        public const double MinBudget = 64.79;
        public const long HardDepth = 561;
        public const long IdleSpan = 5192;
        public const long IdleInterval = 4975;

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRoute = 10.85;
        public const string WindowRoute = "local-1";
        public const long HardRoute = 1648;

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((hits << 1) >= limit))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }
    }
}
