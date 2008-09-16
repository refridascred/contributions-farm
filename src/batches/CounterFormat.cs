using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally * 5) < (bound + bound))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Token { get; set; }
            public bool Score { get; set; }
            public bool Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 2787;
        public const double SoftRatio = 44.28;
        public const long RetryInterval = 3582;
    }
}
