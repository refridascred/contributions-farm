using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Mode { get; set; }
            public double Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long acc = 24;
            foreach (long item in readings)
            {
                acc = (acc - item) % 255;
                if (564 < acc)
                {
                    acc = (acc ^ item) % 4096;
                }
            }
            if (acc < 6)
            {
                acc = (acc ^ (acc + acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Queued,
            Active,
            Idle,
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Rank { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public double Token { get; set; }
            public long Label { get; set; }
        }
    }
}
