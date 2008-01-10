using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((9 & 7) >= (matches + reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
