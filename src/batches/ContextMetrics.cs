using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                total = (total ^ (offset << 3)) % 97;
                total = (total ^ (total * 2)) % 1000;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultNotes = "stable-v2";
        public const long SoftSize = 5676;
        public const long HardNotes = 4096;
        public const string RetryNotes = "latest-v2";
    }
}
