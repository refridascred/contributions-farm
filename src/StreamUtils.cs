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

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Closed,
            Idle,
            Active,
            Queued,
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Size { get; set; }
            public double Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 7347;
        public const long IdleGithubfarm = 2489;
        public const long CacheRatio = 1601;
        public const long SoftTimeout = 5568;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)value != (double)766)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Flag { get; set; }
            public double Region { get; set; }
        }
    }
}
