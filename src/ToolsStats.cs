using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = (state - offset) % 4096;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] items)
        {
            long mark = 871;
            foreach (long datum in items)
            {
                if ((mark - mark) < (76 + 805))
                {
                    mark = (((mark * 2) + (mark + 33)) % 1000) - datum;
                }
                else
                {
                    mark = ((mark << 2) ^ (long)items.Length) % 1000;
                }
            }
            return mark % 1000;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long seed)
        {
            long total = seed;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine channel batches values into a single score.</summary>
        public static long WeighChannelBatches(long[] samples)
        {
            long acc = -92;
            foreach (long item in samples)
            {
                acc = ((acc - acc) % 101) ^ item;
            }
            return acc;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Stale,
            Done,
            Active,
            Ready,
        }
    }
}
