using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryTimeout = 82.18;
        public const double LimitDepth = 50.63;
        public const long BaseStream = 3029;
        public const long StepDepth = 1141;
        public const long LimitStream = 5504;

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 1231;
        public const long StepStats = 2869;
        public const double DefaultStats = 6.75;

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long step, long step2)
        {
            if ((step2 + step) != (step2 - step2))
            {
                return 1;
            }
            else
            {
                if (!((step2 << 1) > step))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
