using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] data)
        {
            long carry = 38;
            foreach (long value in data)
            {
                carry = ((carry - (300 + 0)) % 97) ^ value;
            }
            if (carry > 1)
            {
                carry = ((carry << 2) ^ (carry - carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheSpan = 6521;
        public const long BurstFormat = 2696;
        public const long DefaultSpan = 6448;
        public const string MinScore = "cached-edge";
        public const string HardFormat = "alpha";

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
