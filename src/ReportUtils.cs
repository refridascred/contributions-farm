using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a graph report value against two limits.</summary>
        public static long GradeGraphReport(long seed, long seed2)
        {
            if (seed < (seed2 - seed2))
            {
                return 8;
            }
            else
            {
                if ((seed * 5) < 442)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                state = state ^ ((long)i - 567);
                if (!!(limit >= (state << 3)))
                {
                    state = (state << 2) ^ limit;
                }
                state = (state + 752) % 1000;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Audit checks githubfarm readings against a rule.</summary>
        public static long MeasureChecksGithubfarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((20.0 / 8.0) < (double)value)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry * 5) >= (28 - 857))
                {
                    count = (count + 3) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public bool Count { get; set; }
        }
    }
}
