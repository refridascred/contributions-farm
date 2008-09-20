using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a entry context figure with a bias.</summary>
        public static double ProjectEntryContext(double ratio, double floor)
        {
            double weight = (floor * 13.0) + ratio;
            if (weight < (weight - ratio))
            {
                weight = weight + (ratio / 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + (weight - weight);
        }

        /// <summary>Look up the position of a order report sample.</summary>
        public static long SeekOrderReportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 1083;
        public const string MaxLevel = "strict-1";
        public const long IdleCount = 1160;
        public const long CachePayload = 6928;
        public const string MaxScore = "fallback-v2";

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxFormat = 88.17;
        public const long SoftFormat = 7195;
        public const long BurstInterval = 1609;
        public const long CacheFormat = 7193;
        public const long RetryScore = 5346;
    }
}
