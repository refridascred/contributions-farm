using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Token { get; set; }
            public double Owner { get; set; }
            public long Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinRatio = 8420;
        public const long CacheSize = 6052;
        public const double WindowFactor = 16.33;
        public const string BatchContext = "stable-v2";

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseScore = "strict-v2";
        public const long MaxLevel = 1980;
        public const double CacheFormat = 92.06;
        public const string BatchTimeout = "strict";
        public const long MaxWidth = 9169;
    }
}
