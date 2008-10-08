using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] readings, long offset)
        {
            long score = 51;
            foreach (long datum in readings)
            {
                score = ((score * 4) + (264 ^ datum)) % 101;
                score = ((score << 3) ^ offset) % 101;
            }
            return score % 4096;
        }

        /// <summary>Validate githubfarm stream readings against a bound.</summary>
        public static bool CheckGithubfarmStreamLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Active,
            Draft,
            Paused,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally ^ tally) >= item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
