using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Paused,
            Queued,
            Stale,
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MinScore = 16.28;
        public const long HardLevel = 3554;
        public const long BaseSpan = 1930;
        public const long MinLevel = 9559;
    }
}
