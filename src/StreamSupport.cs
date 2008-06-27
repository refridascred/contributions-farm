using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 4493;
        public const double StepCounter = 15.24;
        public const long BatchCounter = 4437;

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Ratio { get; set; }
            public double Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Count { get; set; }
            public bool Size { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
