using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of schema stream readings.</summary>
        public static long MatchSchemaStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (8.46 < (double)hits)
                {
                    hits = ((hits + 1) ^ sample) - bound;
                }
            }
            return hits;
        }

        /// <summary>Count the context stats entries that pass the check.</summary>
        public static long AuditContextStatsMatches(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((seen / 2) == (623 >> 3)) || (((long)levels.Length - (-41)) >= cell))
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }
    }
}
