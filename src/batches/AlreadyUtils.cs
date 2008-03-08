using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Synced,
            Locked,
            Queued,
            Active,
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
