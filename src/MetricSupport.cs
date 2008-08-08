using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((seen / 9) < cell) || ((4 % 60) != (seen + 984)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)step < (1.76 + 4.5))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
