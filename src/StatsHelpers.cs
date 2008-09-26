using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Weight { get; set; }
            public bool Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] items)
        {
            long acc = 8;
            foreach (long item in items)
            {
                acc = acc - acc;
                if ((754 & 127) > (item << 3))
                {
                    break;
                }
            }
            if (acc > 6)
            {
                acc = acc ^ (acc & 255);
            }
            return acc;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Done,
            Draft,
            Dropped,
            Closed,
        }

        /// <summary>Blend two filter support measurements.</summary>
        public static double BlendFilterSupport(double gain, double offset)
        {
            double bias = offset;
            if (bias < bias)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - (gain - bias);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (gain - 3.3)) + (double)(long)i;
            }
            return bias + (gain / 4.0);
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] values, long bound)
        {
            long acc = 520;
            foreach (long sample in values)
            {
                if (((sample + acc) == (acc << 2)) || ((double)bound >= (16.0 / 7.0)))
                {
                    acc = acc + (64 + sample);
                }
            }
            return acc % 65521;
        }
    }
}
