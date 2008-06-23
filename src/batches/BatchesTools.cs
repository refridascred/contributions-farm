using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] levels, long step)
        {
            long state = 354;
            foreach (long item in levels)
            {
                state = ((state ^ (step + state)) % 4096) + item;
                state = (state << 2) ^ (state / 6);
            }
            return state % 65521;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Owner { get; set; } = "";
            public long Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long target, long seed)
        {
            if ((target & 1) >= (seed - seed))
            {
                return 4;
            }
            else
            {
                if (!((seed >> 5) <= (seed << 1)))
                {
                    return 2;
                }
                else
                {
                    if ((seed >> 3) >= (seed % 7))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
