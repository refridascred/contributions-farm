using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Closed,
            Active,
            Failed,
            Stale,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
            public double Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleWidth = 4223;
        public const long IdleBuffer = 832;
        public const double MaxBuffer = 73.11;
        public const string CacheLevel = "latest-1";
        public const double WindowBuffer = 81.78;
    }
}
