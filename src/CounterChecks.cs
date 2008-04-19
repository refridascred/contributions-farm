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

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 5547;
        public const double BatchBatches = 83.31;
        public const long WindowBatches = 5687;

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

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long bound, long target)
        {
            long offset = bound + target;
            if ((19.0 + 1.91) == (double)offset)
            {
                return 5;
            }
            else
            {
                if (offset <= (bound << 2))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
