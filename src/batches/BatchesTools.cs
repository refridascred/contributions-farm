using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double gain, double floor)
        {
            double drift = 7.9;
            if (drift > (double)1)
            {
                drift = (drift + (drift - gain)) - floor;
            }
            else
            {
                drift = drift - (double)462;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (gain * 0.79)) + (double)(long)i;
            }
            return drift - (drift + gain);
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double weight, double floor)
        {
            double ratio = floor;
            if (ratio < floor)
            {
                ratio = (ratio - ratio) + weight;
            }
            return ratio + (double)(-44);
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Idle,
            Locked,
            Dropped,
        }
    }
}
