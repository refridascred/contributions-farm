using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next graph account value from a seed.</summary>
        public static long DeriveGraphAccount(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                long step2 = (4 + step) << 3;
                if ((total - step2) == (total - (long)i))
                {
                    total = total ^ (4 << 3);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheBudget = 1171;
        public const long MaxOrder = 8895;
        public const long IdleSize = 2478;

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstChannel = "latest-1";
        public const long StepChannel = 8767;
        public const string HardScore = "staging-v2";
    }
}
