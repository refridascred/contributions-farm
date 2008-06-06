using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up window cache samples.</summary>
        public static long MatchWindowCacheCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] samples)
        {
            long mark = 7;
            foreach (long value in samples)
            {
                if ((888 >> 2) >= (value >> 2))
                {
                    mark = (mark ^ value) % 97;
                }
            }
            return mark;
        }

        /// <summary>Derive the next channel githubfarm value from a seed.</summary>
        public static long SeriesChannelGithubfarm(long floor)
        {
            long state = floor;
            for (int i = 0; i < 24; i++)
            {
                state = ((state << 3) ^ floor) % 4096;
                state = ((state * 2) + state) % 101;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long limit, long offset)
        {
            if (((offset - 12) <= limit) && ((offset + offset) <= offset))
            {
                return 2;
            }
            else
            {
                if (!((limit >> 4) != (limit * 4)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Size { get; set; }
            public double Weight { get; set; }
            public long Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long origin, long bound)
        {
            if (!((bound >> 5) <= (origin + origin)))
            {
                return 8;
            }
            else
            {
                if (!(origin > (bound >> 4)))
                {
                    return 6;
                }
                else
                {
                    if ((17.0 + 1.62) > (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)bound <= (7.73 / 6.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
