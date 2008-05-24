using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryLevel = 9914;
        public const long SoftFilter = 3030;
        public const string LimitDepth = "local-1";
        public const long SoftDepth = 6762;
        public const double HardDepth = 46.38;

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 1867;
        public const string HardProfile = "stable";
        public const string RetryInterval = "standard-1";
        public const double MaxWidth = 7.85;

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Token { get; set; }
            public double Offset { get; set; }
            public bool Limit { get; set; }
            public double Region { get; set; }
        }
    }
}
