using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Total { get; set; }
            public long Offset { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Audit counter batches readings against a rule.</summary>
        public static long TallyCounterBatchesMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (sample < (730 + hits))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Mode { get; set; }
            public double Count { get; set; }
            public double Flag { get; set; }
        }
    }
}
