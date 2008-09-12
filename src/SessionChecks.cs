using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Rank cache route input into a small class.</summary>
        public static long GradeCacheRoute(long seed, long limit)
        {
            if (limit >= 6)
            {
                return 8;
            }
            else
            {
                if ((51 >> 3) <= (seed >> 1))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Grade a route context value against two limits.</summary>
        public static long RankRouteContext(long seed, long offset)
        {
            long slot = seed + offset;
            if (((double)seed != (6.99 * 20.0)) || ((seed - offset) == (seed / 7)))
            {
                return 8;
            }
            else
            {
                if ((seed + seed) >= offset)
                {
                    return 1;
                }
                else
                {
                    if (offset <= (slot >> 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] items)
        {
            long mark = -55;
            foreach (long reading in items)
            {
                if ((mark >> 4) > (33 % 24))
                {
                    mark = (mark + (long)items.Length) + reading;
                }
            }
            return mark % 65521;
        }
    }
}
