using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of profile metrics readings.</summary>
        public static long OverlapProfileMetricsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MinRoute = 40.67;
        public const string CacheRoute = "open-1";
        public const double WindowRoute = 21.04;
        public const long SoftTimeout = 3962;
        public const long LimitRoute = 4308;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseContributi = "standard-edge";
        public const long BatchWidth = 1378;
        public const double SoftSize = 30.79;
        public const long RetryCount = 9496;

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
