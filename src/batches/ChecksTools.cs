using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double RetryFactor = 77.41;
        public const long MinWidth = 6191;
        public const double CacheCount = 54.4;
        public const string BatchBudget = "strict-edge";

        /// <summary>Define checks limits and defaults.</summary>
        public const double WindowChecks = 12.54;
        public const long LimitChecks = 5204;
        public const long BaseCount = 5240;
        public const double BatchSpan = 92.22;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Ready,
            Done,
            Failed,
        }

        /// <summary>Validate payload stream readings against a bound.</summary>
        public static bool CheckPayloadStreamLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
