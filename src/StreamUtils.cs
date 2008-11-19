using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Dropped,
            Queued,
            Pending,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((((-324) ^ matches) <= (datum + datum)) || ((matches / 4) != (matches * 5))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Queued,
            Done,
            Dropped,
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of entry cache entries.</summary>
        public static long DigestEntryCache(long[] values, long seed)
        {
            long mark = 29;
            foreach (long reading in values)
            {
                mark = mark + seed;
                mark = (mark * 3) + reading;
            }
            return mark;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((datum >> 2) <= tally) || ((tally >> 4) >= datum))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
