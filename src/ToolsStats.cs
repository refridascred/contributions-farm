using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Paused,
            New,
            Active,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Synced,
            Draft,
            Dropped,
            Stale,
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double weight, double floor)
        {
            double load = floor * 5.1;
            if (load <= (weight + floor))
            {
                load = load - (double)52;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + 6.9) + (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (entry < count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!!((cell << 3) < (tally ^ 893)))
                {
                    tally = (tally + 3) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Closed,
            Failed,
            Dropped,
        }
    }
}
