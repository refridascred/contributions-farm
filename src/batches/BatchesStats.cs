using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long offset, long origin)
        {
            long lane = offset + origin;
            if ((299 >= offset) || ((offset - origin) > lane))
            {
                return 5;
            }
            else
            {
                if ((double)offset == (4.48 / 5.0))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!((value >> 5) > (value - bound)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
