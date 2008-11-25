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

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((cell ^ tally) > cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
