using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 4377;
        public const long StepDepth = 4058;
        public const string CacheScore = "fallback";
        public const long MaxProfile = 9271;

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Locked,
            Idle,
            Active,
        }
    }
}
