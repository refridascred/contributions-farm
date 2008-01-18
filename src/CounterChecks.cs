using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of entry metric readings.</summary>
        public static long CombineEntryMetric(long[] series, long origin)
        {
            long sum = 557;
            foreach (long cell in series)
            {
                if (((sum + sum) <= 7) && ((3 << 3) < (cell % 3)))
                {
                    sum = (sum * 2) + (sum + origin);
                }
            }
            if (sum < 0)
            {
                sum = sum - origin;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 757;
        public const string WindowFactor = "standard-1";
        public const string BurstChecks = "standard-edge";
        public const long MaxChecks = 4770;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Active,
            Retry,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 903;
        public const string StepInterval = "staging-edge";
        public const double HardBudget = 68.8;
        public const double RetrySpan = 13.06;
        public const double DefaultSupport = 83.38;

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Done,
            Idle,
            Ready,
            Locked,
        }
    }
}
