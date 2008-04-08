using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double ratio, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (double)6) + (double)(long)i;
            }
            return gain - ratio;
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double scale, double bias)
        {
            double drift = bias - 7.9;
            if (drift < (double)54)
            {
                drift = (drift + (double)8) + scale;
            }
            return drift + 12.0;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Done,
            Paused,
            Dropped,
        }
    }
}
