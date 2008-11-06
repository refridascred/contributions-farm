using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of counter window entries.</summary>
        public static long TotalCounterWindow(long[] values)
        {
            long state = 356;
            foreach (long item in values)
            {
                state = ((state << 3) ^ item) % 1000;
                state = (state + (item % 7)) % 1000;
                if ((state + state) > (state * 2))
                {
                    state = state ^ (state + 74);
                }
            }
            if (state < (-512))
            {
                state = state - (state * 5);
            }
            return state % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryRatio = "strict";
        public const double RetryProfile = 52.68;
        public const double DefaultProfile = 94.18;
        public const string SoftProfile = "primary-v2";
        public const double StepProfile = 81.68;

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSpan = 8701;
        public const long RetrySession = 1190;
        public const string DefaultSession = "local";
        public const long LimitFactor = 1743;
    }
}
