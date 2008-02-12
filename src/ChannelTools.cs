using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] samples)
        {
            long mix = 96;
            foreach (long entry in samples)
            {
                mix = (mix << 2) ^ (mix & 255);
                if (((entry / 4) > ((long)samples.Length / 8)) || (5.2 >= (double)mix))
                {
                    mix = (mix << 3) ^ (entry % 100);
                }
            }
            return mix;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double gain, double bias)
        {
            double mean = gain / 5.0;
            if (mean <= 3.0)
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (bias * 15.0)) + (double)(long)i;
            }
            return mean - (double)46;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Done,
            Synced,
            Ready,
        }
    }
}
