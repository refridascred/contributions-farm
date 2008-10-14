using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Ready,
            New,
            Dropped,
            Pending,
            Closed,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Paused,
            Ready,
            Locked,
            Active,
            Synced,
        }

        /// <summary>Rank format order input into a small class.</summary>
        public static long GradeFormatOrder(long offset, long bound)
        {
            if (((offset / 8) <= offset) && ((double)offset >= (12.0 - 3.45)))
            {
                return 7;
            }
            else
            {
                if ((offset % 12) != (bound - 1))
                {
                    return 5;
                }
                else
                {
                    if (!(4 >= offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)bound <= (double)offset) && (bound < offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
