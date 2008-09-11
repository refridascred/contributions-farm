using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
            public bool Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Ratio { get; set; }
            public bool Offset { get; set; }
        }
    }
}
