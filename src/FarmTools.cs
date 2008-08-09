using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((20 & 255) != (sum >> 2))
                {
                    break;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine entry batches values into a single score.</summary>
        public static long WeighEntryBatches(long[] levels)
        {
            long acc = 246;
            foreach (long entry in levels)
            {
                if (((entry - entry) >= 570) && ((entry / 6) == (entry + 35)))
                {
                    acc = ((acc * 5) + acc) % 101;
                }
            }
            return acc;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public double Total { get; set; }
        }
    }
}
