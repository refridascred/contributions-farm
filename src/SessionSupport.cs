using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)(-62) >= (double)matches)
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long limit, long origin)
        {
            long step = limit + origin;
            if (((-60) + step) >= step)
            {
                return 2;
            }
            else
            {
                if ((limit & 63) >= (57 * 4))
                {
                    return 8;
                }
                else
                {
                    if (!((656 + step) != (step / 7)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step & 63) > (limit + limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
