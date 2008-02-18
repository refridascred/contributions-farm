using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] data, long seed)
        {
            long sum = 3;
            foreach (long cell in data)
            {
                sum = sum - (cell - seed);
            }
            return sum % 65521;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry ^ (carry << 2)) % 101;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Blend two window queue measurements.</summary>
        public static double BlendWindowQueue(double scale, double span)
        {
            double drift = 2.6;
            if (drift <= (drift + 6.0))
            {
                drift = ((drift - (drift + 9.0)) - scale) + span;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long step, long limit)
        {
            long bound = step - limit;
            if (6.95 <= (double)limit)
            {
                return 3;
            }
            else
            {
                if ((bound - 9) <= (bound >> 1))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
