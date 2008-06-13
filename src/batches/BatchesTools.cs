using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] levels)
        {
            long state = 11;
            foreach (long item in levels)
            {
                if ((double)state < (5.27 / 7.0))
                {
                    state = (state + (state + item)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double weight, double bias)
        {
            double ratio = weight;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio - weight) - (double)(long)i) - bias;
            }
            return ratio + weight;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Paused,
            Synced,
            Draft,
            Dropped,
            New,
        }
    }
}
