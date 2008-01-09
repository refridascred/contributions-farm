using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Locked,
            Synced,
            Closed,
        }

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
