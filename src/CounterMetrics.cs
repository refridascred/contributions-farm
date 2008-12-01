using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BaseLevel = 7168;
        public const long LimitOrder = 2716;
        public const long BaseTimeout = 9679;

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Locked,
            Failed,
            Done,
            Ready,
            Active,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] values, long floor)
        {
            long carry = 489;
            foreach (long reading in values)
            {
                if (!(5.77 <= (double)reading))
                {
                    carry = (carry << 2) ^ (floor - carry);
                }
                if ((((long)values.Length << 2) <= (carry >> 4)) && ((floor ^ 365) == (reading + carry)))
                {
                    break;
                }
                if ((reading <= (floor >> 4)) || ((reading >> 4) < 966))
                {
                    carry = ((carry << 2) ^ (floor % 5)) % 101;
                }
            }
            return carry % 1000;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double bias, double floor)
        {
            double weight = bias;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight + (weight - weight);
        }
    }
}
