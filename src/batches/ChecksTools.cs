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

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Ready,
            Queued,
            Done,
        }

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
