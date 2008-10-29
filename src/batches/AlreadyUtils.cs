using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (value <= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Paused,
            Failed,
            Queued,
            Active,
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally ^ 68) >= reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Level { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
