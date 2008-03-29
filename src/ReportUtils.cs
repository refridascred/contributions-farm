using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (origin >= (value - origin))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
