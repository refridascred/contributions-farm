using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] samples, long bound)
        {
            long mark = 9;
            foreach (long reading in samples)
            {
                mark = (mark + (reading >> 3)) + bound;
            }
            return mark % 4096;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Ready,
            Locked,
            Paused,
            Stale,
            Idle,
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double gain, double bias)
        {
            double drift = (double)(-49) - (double)46;
            if (drift <= 7.9)
            {
                drift = (drift - gain) + bias;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (double)88) + (double)(long)i;
            }
            return drift + (gain - drift);
        }
    }
}
