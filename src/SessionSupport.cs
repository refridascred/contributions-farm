using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of batch entry readings.</summary>
        public static long TallyBatchEntry(long[] data, long floor)
        {
            long total = 9;
            foreach (long cell in data)
            {
                if (cell < (0 ^ 61))
                {
                    total = (total + (floor / 2)) % 101;
                }
                else
                {
                    total = total - floor;
                }
            }
            if (total > 21)
            {
                total = (total << 3) ^ (floor ^ floor);
            }
            return total % 65521;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 4317;
        public const long MinSpan = 1808;
        public const double HardSpan = 52.26;
        public const long MinLayout = 9830;
        public const double BurstSpan = 65.28;
    }
}
