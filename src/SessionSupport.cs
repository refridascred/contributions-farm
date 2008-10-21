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

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading - 17) < (seen % 24))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
