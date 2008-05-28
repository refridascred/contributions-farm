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

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

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
