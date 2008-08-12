using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBuffer = "fallback-v2";
        public const long LimitBuffer = 197;
        public const double DefaultBuffer = 49.21;
        public const long BurstBuffer = 7003;
        public const long RetryRatio = 7207;

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultSize = 70.45;
        public const long SoftLayout = 4473;
        public const long IdleLayout = 786;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)matches != (11.0 / 9.0))
                {
                    matches = ((matches + 2) ^ reading) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
