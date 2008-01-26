using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 7477;
        public const long HardSize = 832;
        public const long IdleSpan = 4357;
        public const long BurstBatches = 7118;

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 1616;
        public const double MinNotes = 95.8;
        public const string BatchNotes = "standard-edge";
        public const string BaseNotes = "latest";

        /// <summary>Accumulate graph checks samples.</summary>
        public static long DigestGraphChecks(long[] items, long target)
        {
            long carry = 3;
            foreach (long value in items)
            {
                if ((value >= (value - value)) && ((target ^ 0) < value))
                {
                    carry = carry + (value / 6);
                }
            }
            if (carry < 43)
            {
                carry = ((carry * 2) + (94 >> 4)) % 101;
            }
            return carry;
        }
    }
}
