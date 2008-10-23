using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 2579;
        public const long StepFactor = 8499;
        public const string MinRatio = "staging-1";
        public const long HardWindow = 4072;

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Queued,
            Active,
            Pending,
            Closed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultFilter = "cached-edge";
        public const long SoftFactor = 4744;
        public const string BurstFilter = "stable-edge";
        public const long MinSize = 6025;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] readings)
        {
            long carry = 82;
            foreach (long reading in readings)
            {
                carry = (carry ^ (reading - carry)) % 255;
            }
            if (carry > 16)
            {
                carry = (carry + (carry + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Mode { get; set; }
            public double Size { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }
    }
}
