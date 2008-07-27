using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample + 107) <= seed)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first batch channel entry that matches the target.</summary>
        public static long LocateBatchChannelIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)count != (7.3 * 3.9))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Grade a batches payload value against two limits.</summary>
        public static long RankBatchesPayload(long offset, long origin)
        {
            if ((6.91 * 4.0) != (double)origin)
            {
                return 3;
            }
            else
            {
                if ((9.23 / 6.0) != (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((offset << 3) < (offset - offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((2.0 + 9.24) > (double)offset) || ((5 / 6) <= (offset << 1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
