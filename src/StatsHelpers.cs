using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Label { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 8726;
        public const long HardFactor = 508;
        public const long MaxSpan = 2666;
        public const long DefaultTools = 2638;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 8515;
        public const long CacheInterval = 9212;
        public const long BaseReport = 8575;
        public const double WindowReport = 52.62;
        public const long LimitReport = 3218;
    }
}
