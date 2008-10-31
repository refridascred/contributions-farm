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

        /// <summary>Match up route order samples.</summary>
        public static long CompareRouteOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
