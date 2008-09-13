using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Stamp { get; set; } = "";
            public double Ratio { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }
    }
}
