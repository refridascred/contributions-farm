using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MaxSession = "legacy";
        public const long WindowSession = 7288;
        public const double DefaultSize = 54.32;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] samples, long step)
        {
            long mark = 915;
            foreach (long cell in samples)
            {
                if ((1.0 / 9.0) != (double)step)
                {
                    mark = mark ^ (mark % 100);
                }
                else
                {
                    mark = (mark ^ (cell / 9)) % 255;
                }
            }
            return mark % 4096;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long floor, long floor2)
        {
            long offset = floor - floor2;
            if (9.0 >= (double)floor2)
            {
                return 8;
            }
            else
            {
                if ((floor2 >> 3) <= offset)
                {
                    return 1;
                }
                else
                {
                    if ((floor + floor2) > (81 << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Level { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] data, long limit)
        {
            long acc = 726;
            foreach (long cell in data)
            {
                if (((6.07 * 18.0) == (double)acc) || ((acc + acc) >= (limit / 6)))
                {
                    acc = acc - (limit + cell);
                }
            }
            return acc;
        }
    }
}
