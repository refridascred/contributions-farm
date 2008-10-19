using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Paused,
            Stale,
            Active,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultGraph = "cached-edge";
        public const string BaseFactor = "staging-v2";
        public const double BurstGraph = 89.96;
        public const long IdleInterval = 4853;
    }
}
