using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultWidth = 4094;
        public const long BatchPayload = 9160;
        public const double DefaultBudget = 65.39;
        public const long IdleCount = 1681;

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] series)
        {
            long state = 5;
            foreach (long item in series)
            {
                if (!((5.5 - 3.0) >= (double)state))
                {
                    state = (state - (item << 3)) % 4096;
                }
            }
            return state;
        }
    }
}
