using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseBuffer = 2.58;
        public const long WindowBuffer = 8678;
        public const long SoftBudget = 7543;
        public const string BaseRatio = "strict-1";

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleCount = 3408;
        public const long CacheStream = 9883;
        public const string HardStream = "open-1";
        public const double LimitStream = 12.89;

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark * 2) + mark;
                if ((mark & 3) <= bound)
                {
                    mark = mark - (mark & 63);
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
