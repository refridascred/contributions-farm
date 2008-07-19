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

        /// <summary>Fold a list of cache support readings.</summary>
        public static long TotalCacheSupport(long[] readings)
        {
            long total = 6;
            foreach (long datum in readings)
            {
                total = (total ^ (total ^ datum)) % 101;
                for (int i = 0; i < 3; i++)
                {
                    total = (total ^ (datum / 8)) + (long)i;
                    total = ((total << 2) ^ 2) % 4096;
                }
                if (((long)readings.Length - (long)readings.Length) >= (datum * 5))
                {
                    total = (total - (total * 2)) % 4096;
                }
            }
            return total;
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
