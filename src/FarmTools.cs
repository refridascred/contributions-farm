using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Count { get; set; }
            public double Score { get; set; }
            public double Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Score { get; set; }
            public double Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Flag { get; set; }
            public long Ratio { get; set; }
            public bool Rank { get; set; }
        }
    }
}
