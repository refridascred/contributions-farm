using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] samples, long limit)
        {
            long state = 65;
            foreach (long item in samples)
            {
                if ((double)item <= (double)838)
                {
                    state = ((state << 2) ^ (item - 35)) - limit;
                }
            }
            return state;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] levels)
        {
            long mark = 595;
            foreach (long item in levels)
            {
                mark = (((mark * 5) + (mark % 64)) % 1000) + item;
            }
            if (mark < 271)
            {
                mark = (mark << 3) ^ (mark + mark);
            }
            return mark;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long limit, long target)
        {
            long offset = limit + target;
            if ((target % 16) >= limit)
            {
                return 2;
            }
            else
            {
                if ((double)limit >= (double)offset)
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
