using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Failed,
            Locked,
            New,
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Token { get; set; }
            public long Flag { get; set; }
            public bool Label { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
