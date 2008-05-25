using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of channel commits entries.</summary>
        public static long DigestChannelCommits(long[] readings, long seed)
        {
            long state = 39;
            foreach (long item in readings)
            {
                state = (((state - (state + (-11))) % 255) - item) + seed;
            }
            return state;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Total { get; set; }
            public bool Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long floor, long seed)
        {
            long cur = floor ^ seed;
            if (floor >= (seed >> 4))
            {
                return 6;
            }
            else
            {
                if (cur > (seed >> 4))
                {
                    return 2;
                }
                else
                {
                    if (!((cur - 1) > (seed * 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor >> 4) != (cur << 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i - result) > (origin >> 5))
                {
                    result = (result - (origin + result)) % 101;
                    result = ((result * 2) + (origin << 3)) % 4096;
                }
                else
                {
                    result = (result + (result * 5)) % 1000;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
