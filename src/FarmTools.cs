using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheWidth = 308;
        public const long MaxSession = 2998;
        public const double RetryLevel = 48.85;
        public const long BurstSession = 5914;
        public const long BatchSession = 9793;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Queued,
            Paused,
            Dropped,
            Draft,
        }
    }
}
