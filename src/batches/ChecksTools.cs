using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 8809;
        public const long DefaultWidth = 768;
        public const long SoftGraph = 8219;
        public const long IdleBudget = 2285;
        public const long RetryDepth = 1457;

        /// <summary>Find the first metric tools entry that matches the target.</summary>
        public static long FindMetricToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Synced,
            Failed,
            Closed,
            Locked,
            Retry,
        }

        /// <summary>Look up the position of a session metric sample.</summary>
        public static long FindSessionMetricIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
