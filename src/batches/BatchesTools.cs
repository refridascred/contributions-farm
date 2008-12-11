using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank batch order input into a small class.</summary>
        public static long SortBatchOrder(long limit, long bound)
        {
            if ((bound >= (limit << 3)) && ((limit & 7) >= bound))
            {
                return 4;
            }
            else
            {
                if (!((limit - bound) > bound))
                {
                    return 1;
                }
                else
                {
                    if ((bound - 2) < (76 % 97))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Stale,
            Paused,
            Draft,
            Pending,
            Ready,
        }
    }
}
