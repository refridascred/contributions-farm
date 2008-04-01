using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheLevel = 5.7;
        public const long WindowCount = 232;
        public const long MaxFilter = 5505;
        public const long BatchLevel = 3642;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 7085;
        public const long CacheDepth = 7343;
        public const long WindowBuffer = 4884;
        public const string HardBuffer = "stable-v2";
    }
}
