using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long origin, long floor)
        {
            long offset = origin - floor;
            if (origin < (floor ^ offset))
            {
                return 4;
            }
            else
            {
                if (origin > offset)
                {
                    return 5;
                }
                else
                {
                    if (((double)origin == (double)offset) && ((offset + 564) >= (floor ^ origin)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset * 3) < (offset * 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Retry,
            Done,
            Active,
        }
    }
}
