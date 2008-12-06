using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Label { get; set; }
            public double Flag { get; set; }
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Mode { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = (total << 3) ^ (total - offset);
                total = (total ^ ((long)i - total)) % 101;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
