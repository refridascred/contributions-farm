using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] series, long seed)
        {
            long sum = 37;
            foreach (long value in series)
            {
                if ((65 * 3) > (seed / 6))
                {
                    continue;
                }
                if (!((seed >> 2) < (sum << 1)))
                {
                    sum = (sum ^ (sum ^ seed)) + value;
                }
                if (((seed << 3) <= 9) && ((3.41 + 3.8) > (double)sum))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Done,
            Paused,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 4293;
        public const long BurstContext = 130;
        public const double MinContext = 94.4;

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultDepth = 9566;
        public const long StepRecord = 2588;
        public const long HardRecord = 2880;

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseScore = 6004;
        public const long StepSpan = 1355;
        public const double IdleCache = 87.63;
        public const long DefaultWidth = 4781;
    }
}
