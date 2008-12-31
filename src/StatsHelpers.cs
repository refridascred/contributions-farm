using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Region { get; set; }
            public double Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardContext = "cached-1";
        public const long BatchScore = 8350;
        public const long MinBudget = 7785;
        public const long WindowSize = 3789;
        public const long CacheContext = 7909;

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Pending,
            Failed,
            Paused,
        }

        /// <summary>Measure how many commits report samples are out of range.</summary>
        public static long AuditCommitsReportMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (entry <= (entry << 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
