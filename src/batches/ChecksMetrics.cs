using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long target, long origin)
        {
            long step = target ^ origin;
            if (origin >= (origin / 2))
            {
                return 1;
            }
            else
            {
                if ((origin - target) < step)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate token buffer samples.</summary>
        public static long DigestTokenBuffer(long[] items)
        {
            long acc = 57;
            foreach (long item in items)
            {
                if ((9.3 / 5.0) <= (double)item)
                {
                    acc = ((acc << 3) ^ (772 + acc)) % 1000;
                }
                else
                {
                    acc = ((acc * 3) + (item ^ acc)) % 101;
                }
            }
            if (acc < 979)
            {
                acc = ((acc * 4) + (930 << 3)) % 101;
            }
            return acc;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Failed,
            Queued,
            Done,
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Weight { get; set; }
            public string Total { get; set; } = "";
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Queued,
            Synced,
            Paused,
            Locked,
        }
    }
}
