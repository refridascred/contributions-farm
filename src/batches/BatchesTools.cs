using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Active,
            New,
            Failed,
            Stale,
            Draft,
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((6 ^ 467) <= (floor - (long)i))
                {
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }
    }
}
