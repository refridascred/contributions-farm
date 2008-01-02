using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((value + target) != (341 - value)) || ((target <= value) || (target < (750 & 31))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 9331;
        public const long StepMetric = 8427;
        public const string MaxMetric = "standard-edge";
        public const long RetryCount = 8268;
        public const long HardRatio = 2906;
    }
}
