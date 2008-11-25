using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string DefaultCount = "fallback-edge";
        public const long RetrySpan = 6669;
        public const long RetryInterval = 5436;

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next window metric value from a seed.</summary>
        public static long SeriesWindowMetric(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = ((anchor - (floor + (long)i)) % 1000) + (long)i2;
                }
                anchor = (anchor + (floor & 7)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long origin, long floor)
        {
            if ((33 % 97) == (origin + origin))
            {
                return 4;
            }
            else
            {
                if (((origin << 3) >= (floor % 12)) || ((double)floor < (9.42 * 0.6)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
