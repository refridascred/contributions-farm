using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every contributi order entry stays within the limit.</summary>
        public static bool ValidateContributiOrderRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long offset, long target)
        {
            long delta = offset - target;
            if (delta < offset)
            {
                return 5;
            }
            else
            {
                if ((double)offset < (4.85 / 4.0))
                {
                    return 3;
                }
                else
                {
                    if (delta > (offset ^ delta))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((delta * 2) == (1 - target)) && ((double)delta < (7.5 * 3.33)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((item << 3) > count) && ((double)item != (9.0 / 3.0)))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)hits != (18.0 / 2.0))
                {
                    hits = ((hits + 3) + cell) + seed;
                }
            }
            return hits;
        }
    }
}
