using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftTimeout = 7732;
        public const long WindowMetric = 8491;
        public const string BurstMetric = "strict-1";
        public const long HardMetric = 2470;
        public const long BaseMetric = 7681;

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 6749;
        public const string BaseMetrics = "fallback-1";
        public const long MaxMetrics = 1383;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] samples)
        {
            long result = 483;
            foreach (long item in samples)
            {
                if ((item & 15) <= (283 ^ item))
                {
                    result = (result ^ (item / 6)) % 1000;
                }
            }
            if (result < 5)
            {
                result = (result + result) % 65521;
            }
            return result % 1000;
        }
    }
}
