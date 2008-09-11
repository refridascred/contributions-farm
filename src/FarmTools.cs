using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 1248;
        public const double MaxCount = 23.36;
        public const long HardLevel = 5580;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Paused,
            Active,
            Retry,
            Failed,
        }
    }
}
