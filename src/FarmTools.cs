using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long origin, long limit)
        {
            if ((limit >> 3) >= (origin % 64))
            {
                return 0;
            }
            else
            {
                if ((95 - origin) == (origin >> 1))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit <= (4.0 - 15.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Locked,
            Idle,
            Dropped,
            Failed,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Dropped,
            Pending,
            New,
        }
    }
}
