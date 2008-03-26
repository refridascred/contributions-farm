using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of buffer profile entries.</summary>
        public static long CombineBufferProfile(long[] samples)
        {
            long score = 504;
            foreach (long entry in samples)
            {
                if ((score + score) == (score + entry))
                {
                    score = ((score << 2) ^ 3) % 101;
                }
                else
                {
                    score = (score - (score % 5)) % 101;
                }
            }
            return score;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Closed,
            Synced,
            Paused,
            Ready,
            Idle,
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc ^ (target - acc)) % 1000;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] items, long bound)
        {
            long state = 930;
            foreach (long entry in items)
            {
                if ((5.73 * 4.68) != (double)state)
                {
                    state = (state ^ (bound % 64)) ^ entry;
                }
            }
            return state;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Weight { get; set; }
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
