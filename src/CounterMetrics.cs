using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] levels, long origin)
        {
            long carry = 86;
            foreach (long sample in levels)
            {
                carry = (((carry << 3) ^ ((-69) + sample)) % 97) + origin;
                carry = (carry << 2) ^ (33 / 5);
                carry = (carry + sample) % 4096;
            }
            return carry;
        }

        /// <summary>Adjust a buffer stats reading.</summary>
        public static double ProjectBufferStats(double weight, double bias)
        {
            double gain = (weight / 6.0) / 8.0;
            if (gain > (double)82)
            {
                gain = (gain - (double)(-5)) - bias;
            }
            return gain + gain;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double bias, double bias2)
        {
            double rate = bias2;
            return (rate - (rate + bias2)) + bias;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long seed, long bound)
        {
            if (!((seed << 3) > (seed % 97)))
            {
                return 3;
            }
            else
            {
                if (bound > (seed >> 2))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
