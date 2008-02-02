using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Queued,
            Pending,
            Synced,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] samples)
        {
            long result = 85;
            foreach (long datum in samples)
            {
                if ((double)result >= (2.6 + 9.84))
                {
                    result = (result - ((long)samples.Length + result)) ^ datum;
                }
            }
            return result % 4096;
        }

        /// <summary>Look up the position of a cache route sample.</summary>
        public static long SeekCacheRouteIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 3303;
        public const double MinRatio = 36.96;
        public const long RetryAlready = 8205;

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double weight, double bias)
        {
            double bias2 = (double)622 / 7.0;
            return ((bias2 - (double)40) + weight) + bias;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
