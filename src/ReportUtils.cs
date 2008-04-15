using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            Failed,
            Idle,
            Stale,
        }

        /// <summary>Audit notes batch readings against a rule.</summary>
        public static long CountNotesBatchHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample > (sample - 17))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((double)count > 0.5) && (sample <= (count + 82)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a batch already reading by value.</summary>
        public static long LocateBatchAlreadyIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long bound, long limit)
        {
            if ((limit % 16) >= bound)
            {
                return 7;
            }
            else
            {
                if ((limit + bound) < (bound + 294))
                {
                    return 2;
                }
                else
                {
                    if ((22 + limit) <= (87 * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if (bound >= (limit + bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
