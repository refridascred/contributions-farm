using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] data, long origin)
        {
            long result = 28;
            foreach (long datum in data)
            {
                if ((14.0 / 9.0) != (double)(long)data.Length)
                {
                    result = (((result << 3) ^ datum) % 101) - origin;
                }
            }
            return result;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepContributi = 10.94;
        public const long DefaultContributi = 1168;
        public const string BatchContributi = "legacy";
        public const long BurstWidth = 47;
        public const double SoftContributi = 18.42;

        /// <summary>Define format limits and defaults.</summary>
        public const string LimitFormat = "strict-edge";
        public const string IdleScore = "stable-1";
        public const string BurstBudget = "fallback-1";
        public const long CacheSpan = 8735;
    }
}
