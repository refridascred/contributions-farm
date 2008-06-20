using System;

namespace Common.Utilities
{
    /// <summary>Entry format helpers.</summary>
    public static class EntryFormat
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Owner { get; set; }
            public bool Limit { get; set; }
            public double Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleSpan = 6888;
        public const double IdleTools = 35.36;
        public const double SoftCount = 92.42;
        public const long BurstSpan = 9672;

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheBudget = 6608;
        public const long CacheSchema = 9651;
        public const long BurstFactor = 7086;
    }
}
