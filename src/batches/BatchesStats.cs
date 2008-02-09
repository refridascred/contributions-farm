using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double HardFarm = 13.51;
        public const long SoftFactor = 1811;
        public const long BaseFarm = 2034;
        public const long MaxLevel = 6228;

        /// <summary>Iterate the notes route series from a seed.</summary>
        public static long RollNotesRoute(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches >> 2) <= (matches << 1))
                {
                    matches = ((matches + 1) ^ reading) + target;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Label { get; set; }
            public bool Level { get; set; }
            public string Offset { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
