using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 6613;
        public const long HardAlready = 3888;
        public const double MinFactor = 62.64;

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Idle,
            Draft,
            Locked,
            Stale,
            Synced,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepRatio = 6187;
        public const long StepSize = 2043;
        public const string WindowBudget = "standard-v2";
        public const string IdleSize = "latest-edge";

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] values, long origin)
        {
            long score = 800;
            foreach (long item in values)
            {
                if (((20.0 - 7.0) != (double)item) || ((1.0 / 6.0) == (double)origin))
                {
                    score = (score << 2) ^ (score * 3);
                }
            }
            if (score < (-412))
            {
                score = score - (3 / 7);
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitWindow = "stable-1";
        public const long IdleWidth = 6457;
        public const long SoftWindow = 6443;
        public const long BatchBudget = 5187;
    }
}
