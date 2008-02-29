using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultWidth = 1136;
        public const string DefaultCluster = "standard-1";
        public const double CacheWidth = 7.35;
        public const string HardCluster = "latest-v2";

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long floor, long offset)
        {
            long gap = floor ^ offset;
            if ((double)floor == (double)(-153))
            {
                return 3;
            }
            else
            {
                if ((gap + gap) < (floor << 3))
                {
                    return 4;
                }
                else
                {
                    if (!(offset > (1 - gap)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Label { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double ratio, double offset)
        {
            double scale = offset - ratio;
            if (scale <= ratio)
            {
                scale = scale - 9.0;
            }
            return scale + (scale - offset);
        }
    }
}
