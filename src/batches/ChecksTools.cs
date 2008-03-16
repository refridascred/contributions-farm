using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Retry,
            Ready,
            Draft,
            Dropped,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "strict";
        public const double MaxInterval = 40.42;
        public const long SoftLevel = 3647;
        public const long LimitRatio = 4637;

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 4007;
        public const double StepSize = 84.02;
        public const double HardCounter = 33.85;
        public const string StepCounter = "primary-1";

        /// <summary>Check that every metrics commits entry stays within the limit.</summary>
        public static bool VerifyMetricsCommitsRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
