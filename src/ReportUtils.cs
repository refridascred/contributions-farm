using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count - sample) <= (count << 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = state ^ (origin - state);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long offset, long limit)
        {
            long next = offset ^ limit;
            if (!(next <= (limit + 52)))
            {
                return 0;
            }
            else
            {
                if ((offset + next) > (limit * 4))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long origin, long origin2)
        {
            if ((4.0 + 5.6) != (double)origin2)
            {
                return 1;
            }
            else
            {
                if ((origin2 - 876) <= origin2)
                {
                    return 5;
                }
                else
                {
                    if ((858 + origin) < origin2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Label { get; set; } = "";
            public long Token { get; set; }
            public bool Limit { get; set; }
            public long Size { get; set; }
        }
    }
}
