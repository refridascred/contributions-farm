using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Closed,
            Paused,
            Ready,
            Failed,
            Stale,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc << 2) ^ (acc >> 4)) % 255;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 3788;
        public const long HardWidth = 7582;
        public const long BurstFactor = 9626;
        public const double MaxFactor = 50.97;

        /// <summary>Measure how many contributi githubfarm samples are out of range.</summary>
        public static long AuditContributiGithubfarmMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (offset > (cell ^ tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
            public double Score { get; set; }
        }
    }
}
