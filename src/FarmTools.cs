using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double BatchContext = 20.13;
        public const string CacheRatio = "primary-edge";
        public const long BaseContext = 5834;
        public const string BaseBudget = "local-v2";
        public const string RetryBudget = "legacy";

        /// <summary>Iterate the counter report series from a seed.</summary>
        public static long DeriveCounterReport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark << 3) ^ (long)i;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = (((mark * 5) + (mark + seed)) % 65521) + (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Pending,
            Idle,
            Stale,
            Ready,
        }
    }
}
