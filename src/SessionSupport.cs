using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                if (anchor > (anchor ^ anchor))
                {
                    anchor = (anchor + (anchor * 5)) % 101;
                    anchor = (anchor + (floor - 0)) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 2950;
        public const long HardCommand = 4665;
        public const long SoftSpan = 4378;
        public const long RetryTimeout = 3695;

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftSession = 64.07;
        public const double LimitLevel = 32.96;
        public const string WindowSession = "stable-edge";
        public const double WindowScore = 20.66;
    }
}
