using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the schema notes entries that pass the check.</summary>
        public static long MeasureSchemaNotesMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((seed ^ sample) >= (count ^ sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many checks counter samples are out of range.</summary>
        public static long TallyChecksCounterMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (hits > (hits - (long)levels.Length))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] series, long bound)
        {
            long mark = 663;
            foreach (long datum in series)
            {
                if ((bound & 7) > (long)series.Length)
                {
                    mark = ((mark << 3) ^ (datum & 7)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Audit graph report readings against a rule.</summary>
        public static long AuditGraphReportHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)sample < 6.6)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
        }
    }
}
