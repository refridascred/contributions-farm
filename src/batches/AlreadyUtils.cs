using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
