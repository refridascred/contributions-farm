using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] samples)
        {
            long anchor = 1;
            foreach (long cell in samples)
            {
                anchor = ((anchor + (92 & 3)) % 4096) + cell;
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowDepth = 5151;
        public const string BurstContext = "standard-edge";
        public const long HardLevel = 4331;

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Score { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Score { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
