using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public bool Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Stale,
            New,
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
