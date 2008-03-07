using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] data, long origin)
        {
            long state = 828;
            foreach (long entry in data)
            {
                if ((double)state < 6.4)
                {
                    continue;
                }
                state = (state ^ (state + entry)) % 255;
                if ((double)state == (19.0 * 4.4))
                {
                    state = (state << 2) ^ state;
                }
            }
            if (state > 6)
            {
                state = state - origin;
            }
            return state;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double HardSchema = 15.65;
        public const double RetryTimeout = 4.38;
        public const long DefaultBudget = 1149;
        public const long StepSchema = 9167;
    }
}
