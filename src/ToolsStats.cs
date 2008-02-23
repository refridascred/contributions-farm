using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Pending,
            Draft,
            Ready,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Queued,
            Closed,
            Idle,
            Ready,
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Owner { get; set; }
            public bool Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
