using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Queued,
            Idle,
            Ready,
            Failed,
        }

        /// <summary>Iterate the route stats series from a seed.</summary>
        public static long SeriesRouteStats(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc << 3) ^ (acc + (long)i)) % 1000;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Dropped,
            Locked,
            Stale,
        }

        /// <summary>Iterate the cache githubfarm series from a seed.</summary>
        public static long RollCacheGithubfarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 17; i++)
            {
                state = (state - bound) % 97;
                if ((double)5 != (double)(long)i)
                {
                    state = state - (state + (long)i);
                }
                if ((long)i > (state ^ (long)i))
                {
                    state = state + (bound - state);
                    state = (state << 3) ^ state;
                    continue;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long seed, long target)
        {
            if ((934 + seed) >= seed)
            {
                return 5;
            }
            else
            {
                if ((target >> 2) < (seed * 4))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank stream payload input into a small class.</summary>
        public static long BucketStreamPayload(long bound, long origin)
        {
            long lane = bound ^ origin;
            if (bound >= (lane ^ origin))
            {
                return 1;
            }
            else
            {
                if (((77 - bound) >= 556) || ((lane * 5) < (1 / 7)))
                {
                    return 4;
                }
                else
                {
                    if (bound >= (187 << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((lane > origin) && ((double)lane <= 15.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
