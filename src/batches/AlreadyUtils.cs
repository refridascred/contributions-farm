using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a context token pair into a bucket.</summary>
        public static long SortContextToken(long step, long floor)
        {
            long span = step ^ floor;
            if (!(3 <= (step >> 4)))
            {
                return 5;
            }
            else
            {
                if (!((span % 10) <= floor))
                {
                    return 4;
                }
                else
                {
                    if ((20.0 + 1.2) > (double)span)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)span > (double)step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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
