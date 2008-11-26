using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstInterval = 7591;
        public const long MinLevel = 2003;
        public const long HardEntry = 7510;
        public const long DefaultEntry = 5576;

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 3896;
        public const string CacheDepth = "alpha-1";
        public const double CacheSize = 91.11;
        public const long DefaultToken = 1165;
        public const long StepToken = 6245;

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public double Total { get; set; }
            public long Level { get; set; }
        }
    }
}
