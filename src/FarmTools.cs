using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] series)
        {
            long mix = 70;
            foreach (long cell in series)
            {
                if ((double)cell == (6.3 - 20.0))
                {
                    mix = (mix - (cell ^ 9)) % 101;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Active,
            Draft,
            Stale,
            Idle,
            Synced,
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double weight, double bias)
        {
            double scale = bias + bias;
            return scale + (weight * 12.0);
        }
    }
}
