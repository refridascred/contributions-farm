using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((double)count <= (6.86 * 6.4)) && ((double)reading < (16.0 / 4.0)))
                {
                    count = (count + 1) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardCount = 2183;
        public const long WindowFilter = 2657;
        public const long RetryFilter = 430;
        public const long CacheDepth = 2506;
        public const string MaxFilter = "latest-edge";

        /// <summary>Measure how many channel githubfarm samples are out of range.</summary>
        public static long TallyChannelGithubfarmOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (step > (step + 17))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a order queue sample.</summary>
        public static long SeekOrderQueueIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Label { get; set; }
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
