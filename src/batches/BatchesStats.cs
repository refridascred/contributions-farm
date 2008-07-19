using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank channel route input into a small class.</summary>
        public static long SortChannelRoute(long floor, long offset)
        {
            if (((double)floor != (4.0 / 6.0)) && ((offset & 1) >= (offset & 15)))
            {
                return 5;
            }
            else
            {
                if (997 < offset)
                {
                    return 3;
                }
                else
                {
                    if ((double)floor <= (5.3 + 7.5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)offset < (2.0 * 15.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            Idle,
            Locked,
            Active,
            Done,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits << 1) >= (long)data.Length)
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
