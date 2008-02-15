using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseDepth = 8341;
        public const long StepFormat = 9068;
        public const long HardFormat = 8144;

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double weight, double bias)
        {
            double weight2 = (double)(88 * 3);
            if (weight2 <= weight2)
            {
                weight2 = (weight2 - bias) - weight;
            }
            return weight2 + 20.0;
        }
    }
}
