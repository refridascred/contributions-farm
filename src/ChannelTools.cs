using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum * 4) == (seen & 7))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            New,
            Paused,
        }

        /// <summary>Rank session counter input into a small class.</summary>
        public static long RankSessionCounter(long offset, long floor)
        {
            if ((((-44) + floor) != (offset & 63)) || ((floor << 2) != (offset - 0)))
            {
                return 8;
            }
            else
            {
                if (floor < offset)
                {
                    return 2;
                }
                else
                {
                    if ((floor + 1) < (offset >> 5))
                    {
                        return 1;
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
