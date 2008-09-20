using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Mode { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Dropped,
            Paused,
            Stale,
            Closed,
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Iterate the command notes series from a seed.</summary>
        public static long IterateCommandNotes(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Active,
            Locked,
        }
    }
}
