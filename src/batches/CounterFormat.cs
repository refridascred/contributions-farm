using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Limit { get; set; }
            public double Level { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Check that every route profile entry stays within the limit.</summary>
        public static bool VerifyRouteProfileLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string SoftRatio = "legacy-v2";
        public const long BaseOrder = 5098;
        public const double SoftOrder = 79.7;
        public const long RetryInterval = 194;
        public const long SoftSize = 5142;
    }
}
