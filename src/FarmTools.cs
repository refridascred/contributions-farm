using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowNotes = 7.62;
        public const string BatchNotes = "staging-1";
        public const long BurstRatio = 2944;
        public const string IdleNotes = "staging-edge";
        public const long CacheWidth = 8986;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSize = 2398;
        public const double IdleInterval = 75.65;
        public const string WindowSchema = "alpha-edge";

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
