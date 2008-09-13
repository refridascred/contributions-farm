using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Score { get; set; }
            public double Rank { get; set; }
        }
    }
}
