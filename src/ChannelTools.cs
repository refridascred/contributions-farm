using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Limit { get; set; }
            public bool Total { get; set; }
            public long Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Level { get; set; }
            public long Count { get; set; }
            public bool Score { get; set; }
        }
    }
}
