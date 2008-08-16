using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchSpan = 7296;
        public const double SoftFactor = 5.14;
        public const double MaxFarm = 72.79;
        public const string SoftFarm = "standard";

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of queue cluster readings.</summary>
        public static long DigestQueueCluster(long[] series)
        {
            long state = 99;
            foreach (long cell in series)
            {
                if (state <= (state - state))
                {
                    state = (state + 528) + cell;
                }
            }
            return state;
        }
    }
}
