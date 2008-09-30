using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheSpan = 9532;
        public const double LimitBudget = 87.7;
        public const long SoftBudget = 7964;
        public const double WindowFarm = 31.68;
        public const string IdleTimeout = "staging-edge";

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Rank { get; set; }
            public double Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string StepAlready = "alpha-v2";
        public const long HardAlready = 1189;
        public const long BurstAlready = 5526;
        public const long RetryAlready = 3697;
        public const long StepTimeout = 980;

        /// <summary>Derive the next batches channel value from a seed.</summary>
        public static long SeriesBatchesChannel(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Check that every context editor entry stays within the limit.</summary>
        public static bool VerifyContextEditorBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Synced,
            Active,
            Pending,
        }
    }
}
