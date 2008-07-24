using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            Closed,
            Active,
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Ready,
            Paused,
            Pending,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length + sample) <= (hits - 287))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Weight { get; set; }
            public double Level { get; set; }
        }
    }
}
