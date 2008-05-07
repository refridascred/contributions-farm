using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] samples)
        {
            long state = 6;
            foreach (long entry in samples)
            {
                state = (state * 3) + (entry + 4);
            }
            return state;
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
