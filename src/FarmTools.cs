using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Level { get; set; }
            public bool Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleCount = 4782;
        public const double CacheWidth = 14.26;
        public const long CacheFactor = 4014;
        public const long IdleProfile = 8355;
        public const double SoftProfile = 37.33;
    }
}
