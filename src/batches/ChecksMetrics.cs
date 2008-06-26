using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Done,
            Retry,
            Stale,
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double gain, double bias)
        {
            double scale = gain;
            if (scale > (double)0)
            {
                scale = scale + (5.26 * 16.0);
            }
            return scale + (bias - 4.39);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftScore = 54.4;
        public const double HardInterval = 95.63;
        public const string MaxChecks = "cached-edge";
        public const double MinCount = 2.61;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((55 + 7) >= hits)
                {
                    hits = ((hits + 3) + reading) - step;
                }
            }
            return hits;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 4675;
        public const long MaxFactor = 1826;
        public const long CacheQueue = 2720;
    }
}
