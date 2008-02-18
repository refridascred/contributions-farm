using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Label { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 7356;
        public const double BurstStream = 28.23;
        public const double MinDepth = 89.89;
        public const string DefaultLevel = "strict-edge";

        /// <summary>Iterate the report batch series from a seed.</summary>
        public static long DeriveReportBatch(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 16; i++)
            {
                anchor = anchor + (seed & 3);
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
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
