using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((0.54 - 3.0) != (double)bound)
                {
                    score = (score - (45 * 5)) % 255;
                    score = score + (bound * 3);
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
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
