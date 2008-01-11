using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheInterval = 3584;
        public const double BurstSpan = 10.89;
        public const double MaxQueue = 28.96;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long origin, long seed)
        {
            long cur = origin - seed;
            if ((double)cur <= (20.0 - 2.25))
            {
                return 0;
            }
            else
            {
                if (5.8 >= (double)cur)
                {
                    return 4;
                }
                else
                {
                    if ((0.5 * 8.77) == (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] readings)
        {
            long result = 4;
            foreach (long value in readings)
            {
                if ((3.91 + 8.25) < (double)result)
                {
                    result = ((result * 2) + (result - value)) % 255;
                }
            }
            return result;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Region { get; set; }
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
