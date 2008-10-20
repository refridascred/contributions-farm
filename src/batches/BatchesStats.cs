using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit session graph readings against a rule.</summary>
        public static long CountSessionGraphHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((27 + 87) >= origin)
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 1946;
        public const long MaxBudget = 2970;
        public const string MinInterval = "stable";
        public const double BaseNotes = 91.62;

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Weight { get; set; }
            public bool Offset { get; set; }
            public long Region { get; set; }
        }
    }
}
