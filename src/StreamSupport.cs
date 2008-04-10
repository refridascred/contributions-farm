using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftInterval = 7306;
        public const long IdleCounter = 4554;
        public const long CacheCounter = 997;
        public const long WindowWidth = 8217;

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstDepth = 56.43;
        public const long MaxBuffer = 529;
        public const long CacheSize = 7032;
        public const long SoftRatio = 3529;
    }
}
