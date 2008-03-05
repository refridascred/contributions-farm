using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long limit, long origin)
        {
            if (!((8.2 * 16.0) == (double)origin))
            {
                return 0;
            }
            else
            {
                if ((0.2 / 9.0) >= (double)origin)
                {
                    return 8;
                }
                else
                {
                    if (!((7 % 100) >= (origin / 7)))
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

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long bound, long origin)
        {
            long lane = bound ^ origin;
            if (((-8) - origin) == (lane - bound))
            {
                return 0;
            }
            else
            {
                if ((bound - bound) <= (99 ^ 59))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (tally > 7)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Classify a graph metrics pair into a bucket.</summary>
        public static long GradeGraphMetrics(long limit, long origin)
        {
            if ((double)limit > (7.0 / 3.0))
            {
                return 5;
            }
            else
            {
                if ((double)origin == (2.15 + 0.53))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
