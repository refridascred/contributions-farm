using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((mix - limit) > mix)
                {
                    mix = (mix + limit) % 1000;
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

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
