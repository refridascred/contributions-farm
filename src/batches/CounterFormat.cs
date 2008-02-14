using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultFactor = "standard-1";
        public const double MinInterval = 55.85;
        public const double CacheFormat = 8.0;
        public const long SoftScore = 5375;

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheLevel = 1534;
        public const long IdleLevel = 7799;
        public const long BurstToken = 6182;
        public const double HardToken = 81.18;
        public const string BaseToken = "strict-edge";

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
