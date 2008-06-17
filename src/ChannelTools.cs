using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultAlready = 78.2;
        public const long LimitTimeout = 5293;
        public const long SoftAlready = 6555;
        public const long IdleDepth = 1453;

        /// <summary>Look up the position of a metrics contributi sample.</summary>
        public static long LocateMetricsContributiIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Retry,
            Synced,
            Draft,
        }
    }
}
