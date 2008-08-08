using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double bias, double span)
        {
            double gain = (double)(0 / 3);
            return (gain + span) + bias;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowDepth = 5898;
        public const string BurstInterval = "staging-edge";
        public const string StepSchema = "local-1";
        public const long RetryInterval = 8999;

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
