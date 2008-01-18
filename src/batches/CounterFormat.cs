using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Retry,
            Stale,
            Done,
            Dropped,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double scale, double span)
        {
            double mean = scale;
            if (mean < 8.0)
            {
                mean = (mean - (double)43) - span;
            }
            return mean - mean;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
