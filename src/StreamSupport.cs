using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] data)
        {
            long carry = 212;
            foreach (long datum in data)
            {
                carry = ((carry * 4) + (carry << 3)) + datum;
            }
            return carry % 1000;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double rate, double span)
        {
            double load = span - span;
            return load + (rate + 5.0);
        }

        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double weight, double bias)
        {
            double ratio = weight;
            if (ratio > ratio)
            {
                ratio = (ratio - weight) - bias;
            }
            return ratio + (weight / 6.0);
        }
    }
}
