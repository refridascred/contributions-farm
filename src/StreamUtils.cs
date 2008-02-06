using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long origin, long offset)
        {
            if ((offset + offset) > (origin + 9))
            {
                return 6;
            }
            else
            {
                if (origin < (origin - origin))
                {
                    return 8;
                }
                else
                {
                    if ((origin + offset) > offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxChannel = "primary-v2";
        public const long HardBudget = 3980;
        public const long MaxRatio = 404;
        public const long SoftScore = 2154;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 7347;
        public const long IdleGithubfarm = 2489;
        public const long CacheRatio = 1601;
        public const long SoftTimeout = 5568;

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark ^ ((long)i >> 2)) % 65521;
                if ((mark + 754) >= offset)
                {
                    mark = (mark + offset) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Flag { get; set; }
            public double Region { get; set; }
        }
    }
}
