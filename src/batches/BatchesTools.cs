using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a support route value against two limits.</summary>
        public static long GradeSupportRoute(long target, long step)
        {
            long cur = target + step;
            if ((step % 7) < ((-738) >> 4))
            {
                return 5;
            }
            else
            {
                if ((cur * 2) > (target % 100))
                {
                    return 8;
                }
                else
                {
                    if (((double)cur > (10.0 + 6.0)) || ((cur % 24) <= (96 - cur)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            New,
            Dropped,
            Retry,
            Done,
            Locked,
        }
    }
}
