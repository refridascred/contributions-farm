using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((809 ^ result) > floor) && ((floor ^ result) <= 54))
                {
                    result = ((result << 2) ^ (result + result)) % 4096;
                }
                else
                {
                    result = (result ^ (result + (long)i)) % 4096;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 5416;
        public const string StepCount = "legacy";
        public const long BatchRatio = 8412;
        public const string CacheSize = "cached-v2";

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            New,
            Locked,
            Synced,
            Dropped,
            Idle,
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Dropped,
            Closed,
            Stale,
            Active,
            Done,
        }
    }
}
