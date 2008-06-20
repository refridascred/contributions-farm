using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public bool Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long floor, long limit)
        {
            if (floor > (floor - floor))
            {
                return 3;
            }
            else
            {
                if ((limit << 2) <= (floor >> 5))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Compare every pair of context payload readings.</summary>
        public static long PairContextPayloadCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
