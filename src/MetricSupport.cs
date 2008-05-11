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

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Total { get; set; }
            public double Label { get; set; }
        }
    }
}
