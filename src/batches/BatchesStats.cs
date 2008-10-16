using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 3) + step) % 101;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] levels)
        {
            long total = 123;
            foreach (long datum in levels)
            {
                total = ((total - (long)levels.Length) % 4096) ^ datum;
            }
            return total % 65521;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Weight { get; set; }
            public double Mode { get; set; }
        }
    }
}
