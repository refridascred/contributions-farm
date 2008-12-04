using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Failed,
            Idle,
            Pending,
        }

        /// <summary>Classify a record counter pair into a bucket.</summary>
        public static long GradeRecordCounter(long origin, long bound)
        {
            if ((17.0 * 8.0) < (double)bound)
            {
                return 1;
            }
            else
            {
                if ((19.0 + 10.0) < (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((double)bound >= (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)reading == (8.4 * 17.0))
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long target)
        {
            long acc = target;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long offset, long offset2)
        {
            if (offset <= offset2)
            {
                return 0;
            }
            else
            {
                if ((offset2 ^ offset2) >= (offset2 * 2))
                {
                    return 5;
                }
                else
                {
                    if (offset >= (609 - offset2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
