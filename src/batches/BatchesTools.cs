using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Retry,
            Queued,
            Dropped,
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Draft,
            New,
            Pending,
            Synced,
            Ready,
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long offset, long floor)
        {
            if ((floor < (6 >> 3)) || ((floor - offset) == (floor << 1)))
            {
                return 0;
            }
            else
            {
                if ((floor > (floor ^ floor)) || ((floor ^ floor) > 93))
                {
                    return 2;
                }
                else
                {
                    if (!((double)offset < 0.95))
                    {
                        return 6;
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
