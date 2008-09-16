using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 5862;
        public const double MinQueue = 46.33;
        public const long MinWidth = 5599;
        public const long HardQueue = 90;
        public const long BatchLevel = 1789;

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double gain, double span)
        {
            double drift = span;
            if (drift < drift)
            {
                drift = (drift + drift) - gain;
            }
            return drift + (double)49;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long step)
        {
            long anchor = step;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor + (long)i) % 101;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
