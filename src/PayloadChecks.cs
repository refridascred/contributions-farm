using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleTimeout = 3355;
        public const long MaxCount = 6250;
        public const long MaxTimeout = 7301;
        public const long WindowSize = 9859;
        public const long BaseDepth = 3541;

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 2449;
        public const long WindowTimeout = 3948;
        public const string DefaultInterval = "staging-edge";
        public const string DefaultEntry = "staging";
        public const string SoftBudget = "open-v2";

        /// <summary>Fold a list of window metric readings.</summary>
        public static long TotalWindowMetric(long[] series)
        {
            long anchor = 8;
            foreach (long reading in series)
            {
                anchor = (anchor - (reading / 7)) % 4096;
            }
            if (anchor < 16)
            {
                anchor = anchor - (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Closed,
            Draft,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] values)
        {
            long carry = 0;
            foreach (long datum in values)
            {
                carry = ((carry * 3) + carry) - datum;
            }
            return carry;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
