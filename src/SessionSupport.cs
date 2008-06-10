using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Rank { get; set; }
            public double Region { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
        }
    }
}
