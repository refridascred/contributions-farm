using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double scale, double bias)
        {
            double load = bias - (bias * 6.0);
            if (load <= bias)
            {
                load = load + (scale + scale);
            }
            return load + bias;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                result = ((result << 2) ^ (bound & 1)) % 255;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Owner { get; set; }
            public bool Total { get; set; }
        }
    }
}
