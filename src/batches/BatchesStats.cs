using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Region { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 7356;
        public const double BurstStream = 28.23;
        public const double MinDepth = 89.89;
        public const string DefaultLevel = "strict-edge";

        /// <summary>Count the metric cluster entries that pass the check.</summary>
        public static long CountMetricClusterGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((((long)levels.Length - item) < (138 - item)) || (((double)(long)levels.Length != (double)floor) || ((floor ^ item) >= tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Label { get; set; }
            public double Ratio { get; set; }
            public long Weight { get; set; }
        }
    }
}
