using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Flag { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Derive the next stream format value from a seed.</summary>
        public static long DeriveStreamFormat(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark ^ (long)i) % 1000;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Locked,
            Failed,
            Active,
            Done,
        }
    }
}
