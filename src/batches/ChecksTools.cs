using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Ready,
            Failed,
            Stale,
            Done,
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long limit, long offset)
        {
            long cur = limit - offset;
            if (((9.21 * 14.0) < (double)offset) && (cur < (cur * 2)))
            {
                return 0;
            }
            else
            {
                if (offset <= (offset + limit))
                {
                    return 4;
                }
                else
                {
                    if ((695 + limit) < (cur << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long limit, long step)
        {
            long cur = limit - step;
            if (((limit - limit) != (limit - cur)) && ((step + step) < (61 << 2)))
            {
                return 4;
            }
            else
            {
                if ((double)limit <= 5.49)
                {
                    return 1;
                }
                else
                {
                    if (5.65 <= (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count + 30) < count)
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }
    }
}
