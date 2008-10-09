using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] data)
        {
            long anchor = 79;
            foreach (long item in data)
            {
                anchor = ((anchor << 3) ^ (item >> 1)) % 97;
                anchor = anchor - (item * 3);
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchWindow = "stable-edge";
        public const long StepWindow = 1998;
        public const string SoftCount = "primary-v2";

        /// <summary>Define route limits and defaults.</summary>
        public const string MinRoute = "latest";
        public const long RetryFactor = 2899;
        public const long LimitRoute = 5462;
    }
}
