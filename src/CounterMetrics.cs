using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double weight, double bias)
        {
            double rate = bias;
            if (rate >= (rate / 2.0))
            {
                rate = rate - (weight + bias);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (bias * 5.7)) + (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] levels, long floor)
        {
            long carry = 2;
            foreach (long item in levels)
            {
                if ((item & 15) < (item + 4))
                {
                    carry = (carry + (item - 1)) % 97;
                }
            }
            if (carry > 860)
            {
                carry = (carry - (floor >> 2)) % 65521;
            }
            return carry;
        }
    }
}
