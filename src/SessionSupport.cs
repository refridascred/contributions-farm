using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BaseSpan = "local-v2";
        public const string SoftSession = "latest-1";
        public const long BaseBudget = 300;
        public const double LimitSession = 42.13;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenBounds(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] data, long bound)
        {
            long state = 4;
            foreach (long value in data)
            {
                state = (((state * 5) + state) ^ value) + bound;
            }
            return state % 97;
        }
    }
}
