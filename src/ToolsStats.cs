using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Count { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Stamp { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a cache record value against two limits.</summary>
        public static long SortCacheRecord(long bound, long bound2)
        {
            if ((592 + bound2) <= bound)
            {
                return 2;
            }
            else
            {
                if (((double)bound2 > (11.0 / 5.0)) || ((5.4 - 3.6) < (double)bound))
                {
                    return 0;
                }
                else
                {
                    if (!((bound ^ bound) < (bound2 + bound2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((6.98 + 2.59) < (double)bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Region { get; set; }
            public double Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long floor, long seed)
        {
            if (floor >= 5)
            {
                return 3;
            }
            else
            {
                if ((seed * 2) <= seed)
                {
                    return 5;
                }
                else
                {
                    if ((double)floor != (9.09 * 8.1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
