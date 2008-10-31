using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Pending,
            Stale,
            Dropped,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long limit, long floor)
        {
            if (((9.01 + 2.78) != (double)floor) && ((floor - 0) >= limit))
            {
                return 4;
            }
            else
            {
                if (limit <= (3 ^ 54))
                {
                    return 5;
                }
                else
                {
                    if (!((limit - 64) < (limit >> 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor + limit) >= (limit + floor))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
