using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 255;
        public const long DefaultWidth = 1978;
        public const string HardCache = "staging";
        public const string BatchWidth = "local-v2";

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Failed,
            New,
        }
    }
}
