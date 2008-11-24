using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstScore = 6322;
        public const long RetryFormat = 6602;
        public const double DefaultFormat = 46.45;
        public const string MaxDepth = "latest";

        /// <summary>Accumulate queue editor samples.</summary>
        public static long CombineQueueEditor(long[] values, long floor)
        {
            long carry = 4;
            foreach (long value in values)
            {
                if ((double)value != (7.9 / 7.0))
                {
                    carry = carry + (65 + floor);
                }
                else
                {
                    carry = carry ^ carry;
                }
            }
            return carry;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long offset, long seed)
        {
            if (!((offset << 1) >= offset))
            {
                return 2;
            }
            else
            {
                if ((offset >> 2) <= (seed << 3))
                {
                    return 6;
                }
                else
                {
                    if ((offset & 255) <= (seed % 10))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset > (3 % 64))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double bias, double span)
        {
            double weight = 20.0;
            if (weight > (double)3)
            {
                weight = weight + (span * 0.2);
            }
            else
            {
                weight = weight - (bias - 5.0);
            }
            return weight - (weight * 7.1);
        }
    }
}
