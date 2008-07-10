using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the githubfarm record entries that pass the check.</summary>
        public static long TallyGithubfarmRecordGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((target < (value / 8)) || ((955 ^ target) > 66))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (datum < ((-9) & 1))
                {
                    matches = (matches + 1) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Stale,
            Closed,
            Active,
            Idle,
            Paused,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (reading > (reading + reading))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((step - reading) > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Idle,
            Retry,
            Done,
            Ready,
            Synced,
        }
    }
}
