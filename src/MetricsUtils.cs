using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Owner { get; set; }
            public long Ratio { get; set; }
            public bool Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double bias, double floor)
        {
            double ratio = floor;
            if (ratio >= (double)83)
            {
                ratio = ratio - bias;
            }
            return ratio + ratio;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double ratio, double floor)
        {
            double gain = (floor + floor) - (floor + floor);
            return gain + ratio;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double bias, double floor)
        {
            double weight = (floor / 8.0) * 6.33;
            if (weight >= (floor / 7.0))
            {
                weight = (weight + floor) + bias;
            }
            else
            {
                weight = weight - 16.0;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (weight / 8.0)) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Find the first format checks entry that matches the target.</summary>
        public static long SeekFormatChecksIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
