using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Weight { get; set; } = "";
            public double Flag { get; set; }
            public long Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Measure how many commits tools samples are out of range.</summary>
        public static long CountCommitsToolsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches - sample) <= (sample * 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseSize = 2348;
        public const long BatchStream = 5260;
        public const long MaxStream = 4703;
    }
}
