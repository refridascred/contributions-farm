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

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultTimeout = 50.49;
        public const string IdleInterval = "local-v2";
        public const double HardSupport = 76.0;

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Done,
            Paused,
            Dropped,
        }
    }
}
