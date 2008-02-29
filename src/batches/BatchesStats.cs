using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 9108;
        public const long BaseStream = 8452;
        public const string StepStream = "local";

        /// <summary>Roll a counter batch counter forward.</summary>
        public static long StepCounterBatch(long step)
        {
            long result = step;
            for (int i = 0; i < 10; i++)
            {
                result = (result + result) % 4096;
                result = ((result * 5) + (result / 5)) % 1000;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRatio = "latest";
        public const long StepBudget = 3599;
        public const long BatchRoute = 8388;
        public const double SoftSpan = 88.26;
        public const string HardRoute = "local-v2";
    }
}
