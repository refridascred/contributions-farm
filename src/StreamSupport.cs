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

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long target)
        {
            long mix = target;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
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
