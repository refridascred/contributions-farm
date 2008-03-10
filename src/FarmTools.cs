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

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Stale,
            Pending,
            Locked,
            Retry,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Score { get; set; }
            public long Token { get; set; }
        }
    }
}
