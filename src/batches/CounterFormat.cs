using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Retry,
            Pending,
            Locked,
            Draft,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleCluster = "stable-1";
        public const double IdleCount = 52.82;
        public const long HardCluster = 1863;
        public const string LimitCluster = "stable-edge";
        public const double LimitFactor = 46.15;
    }
}
