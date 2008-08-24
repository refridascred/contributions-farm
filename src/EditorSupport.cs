using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Retry,
            Closed,
            Queued,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long floor, long origin)
        {
            if ((double)floor > (double)origin)
            {
                return 4;
            }
            else
            {
                if (((double)floor < 5.4) || ((double)origin == (double)220))
                {
                    return 0;
                }
                else
                {
                    if (floor >= 410)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((floor << 3) >= (origin >> 2)) || ((floor + origin) > origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double bias, double offset)
        {
            double ratio = 2.6;
            if (ratio < (0.25 + bias))
            {
                ratio = (ratio - (7.18 - bias)) - offset;
            }
            return ratio - 6.7;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((26 + 457) >= seen)
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((target / 6) > (value % 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
