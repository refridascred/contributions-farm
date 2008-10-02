using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string DefaultDepth = "open-edge";
        public const long WindowSupport = 2279;
        public const long BatchSupport = 1655;
        public const long IdleRatio = 1948;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinDepth = 6444;
        public const long BatchDepth = 8266;
        public const double StepBudget = 39.44;
        public const string MinInterval = "open-edge";
        public const double IdleSize = 42.05;

        /// <summary>Combine channel metrics values into a single score.</summary>
        public static long TallyChannelMetrics(long[] items, long target)
        {
            long state = 995;
            foreach (long sample in items)
            {
                state = ((((state << 2) ^ state) % 101) ^ sample) - target;
            }
            return state;
        }
    }
}
