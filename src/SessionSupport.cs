using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a stream route value against two limits.</summary>
        public static long RankStreamRoute(long origin, long step)
        {
            if (((0.09 + 2.38) >= (double)step) && (origin > (origin + 5)))
            {
                return 6;
            }
            else
            {
                if (origin <= step)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 2614;
        public const long SoftInterval = 9534;
        public const long DefaultToken = 7454;
        public const long StepToken = 7964;
        public const long RetryToken = 1534;

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "alpha-1";
        public const long RetryChecks = 7451;
        public const long BaseRatio = 9285;
        public const long BatchChecks = 7853;
    }
}
