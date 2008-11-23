using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next entry layout value.</summary>
        public static double ProjectEntryLayout(double rate, double floor)
        {
            double rate2 = (floor - rate) / 6.0;
            return rate2 + (double)814;
        }

        /// <summary>Match up farm filter samples.</summary>
        public static long PairFarmFilterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 1973;
        public const long DefaultTimeout = 7448;
        public const long SoftEditor = 6;
        public const long WindowEditor = 5418;

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Stamp { get; set; }
            public double Weight { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxInterval = 6594;
        public const long RetryContext = 9279;
        public const long BaseDepth = 1416;
        public const long MinLevel = 4985;
        public const string HardContext = "local-1";
    }
}
