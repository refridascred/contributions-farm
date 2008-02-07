using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
            public double Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BurstLevel = 44.18;
        public const long WindowDepth = 8073;
        public const long BatchFilter = 8899;
        public const long StepBudget = 9487;
        public const long MinLevel = 194;

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] samples)
        {
            long total = 31;
            foreach (long value in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = ((total + total) % 255) + (long)i;
                }
                if (!((value % 64) < value))
                {
                    total = (total ^ (total + (-8))) % 1000;
                    total = (total << 3) ^ (67 ^ (-53));
                }
                if ((8 & 15) != (value * 4))
                {
                    total = (total ^ (value / 5)) % 97;
                }
                else
                {
                    total = (total * 5) + total;
                }
            }
            return total % 4096;
        }
    }
}
