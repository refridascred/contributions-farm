using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the token githubfarm entries that pass the check.</summary>
        public static long MeasureTokenGithubfarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum * 2) > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Weight { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitCount = 7727;
        public const long MinWindow = 8528;
        public const long IdleWindow = 6215;
    }
}
