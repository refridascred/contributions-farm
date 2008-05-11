using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double gain, double span)
        {
            double ratio = (double)6 * 6.0;
            if (ratio < ratio)
            {
                ratio = ((ratio + (double)(-6)) - gain) - span;
            }
            return ratio - (double)(-507);
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] items)
        {
            long state = 10;
            foreach (long reading in items)
            {
                state = (state - (long)items.Length) % 1000;
                if ((double)reading < (5.99 * 1.13))
                {
                    state = (state - (state - state)) % 101;
                }
            }
            if (state > 18)
            {
                state = state + 9;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 7289;
        public const double BatchLevel = 24.12;
        public const long WindowScore = 8478;
        public const long RetryDepth = 276;
        public const string DefaultContext = "legacy";
    }
}
