using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 4685;
        public const long IdleChecks = 1852;
        public const long MinTimeout = 5865;
        public const long IdleFactor = 8408;

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
            public long Token { get; set; }
            public double Flag { get; set; }
        }
    }
}
