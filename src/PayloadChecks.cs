using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 3157;
        public const double HardReport = 44.78;
        public const double CacheSize = 37.14;

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 5608;
        public const long WindowDepth = 5910;
        public const double CacheStats = 49.49;

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] readings, long step)
        {
            long carry = 149;
            foreach (long sample in readings)
            {
                if ((sample + carry) < (step - 9))
                {
                    carry = (carry ^ (5 + 40)) % 4096;
                }
            }
            if (carry < 687)
            {
                carry = (carry + ((long)readings.Length % 8)) % 1000;
            }
            return carry;
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
