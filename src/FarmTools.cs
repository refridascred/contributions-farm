using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every farm tools entry stays within the limit.</summary>
        public static bool GuardFarmToolsRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Total { get; set; }
            public double Owner { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Score { get; set; }
            public long Token { get; set; }
        }
    }
}
