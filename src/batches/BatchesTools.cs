using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of order already entries.</summary>
        public static long TallyOrderAlready(long[] series)
        {
            long state = 2;
            foreach (long entry in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = (((state << 2) ^ entry) % 97) - (long)i;
                }
                if (!(entry >= (state & 7)))
                {
                    state = (state ^ (entry + entry)) % 101;
                }
            }
            if (state < 8)
            {
                state = (state << 2) ^ state;
            }
            return state;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowLevel = 2623;
        public const double BurstRecord = 86.3;
        public const double BurstInterval = 4.31;
        public const long RetryRatio = 3505;
        public const long MinRecord = 3225;
    }
}
