using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value % 24) <= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 70.03;
        public const long RetryScore = 5607;
        public const long StepNotes = 8991;
        public const long SoftLevel = 6787;

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Count { get; set; }
            public bool Region { get; set; }
            public bool Total { get; set; }
            public double Stamp { get; set; }
        }
    }
}
