using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBudget = "latest";
        public const double BaseTimeout = 85.69;
        public const double SoftRatio = 61.08;
        public const string MaxBatch = "fallback-1";
        public const string BaseBatch = "local-edge";

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Ready,
            Locked,
            Idle,
            Paused,
            Active,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Closed,
            New,
            Retry,
            Synced,
            Done,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Token { get; set; }
            public bool Score { get; set; }
            public double Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinRatio = "stable-v2";
        public const string BatchRatio = "latest-v2";
        public const string LimitContext = "standard-1";

        /// <summary>Validate schema order readings against a bound.</summary>
        public static bool CheckSchemaOrderBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
