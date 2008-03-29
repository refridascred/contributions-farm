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

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Label { get; set; } = "";
            public long Mode { get; set; }
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

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
