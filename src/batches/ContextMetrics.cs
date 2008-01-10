using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Locked,
            Dropped,
            Active,
        }

        /// <summary>Measure how many route editor samples are out of range.</summary>
        public static long MeasureRouteEditorOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)origin == (double)tally)
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] readings)
        {
            long score = 876;
            foreach (long reading in readings)
            {
                if ((reading << 3) <= score)
                {
                    score = ((score << 3) ^ reading) % 65521;
                    score = (score * 5) + (reading * 5);
                }
                if ((score + reading) < (score >> 4))
                {
                    score = score ^ (reading & 1);
                }
                else
                {
                    score = ((score * 3) + (448 ^ 888)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Pending,
            Dropped,
            Synced,
            Locked,
            Closed,
        }

        /// <summary>Rank report editor input into a small class.</summary>
        public static long RankReportEditor(long origin, long origin2)
        {
            if (!((481 >> 3) <= (origin - 415)))
            {
                return 8;
            }
            else
            {
                if ((origin2 << 3) < (73 + origin2))
                {
                    return 1;
                }
                else
                {
                    if (origin2 <= (origin2 + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((7.94 + 2.3) <= (double)origin2) && ((double)origin < (8.7 * 9.6)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
