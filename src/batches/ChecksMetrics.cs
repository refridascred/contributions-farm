using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)entry > (7.0 / 5.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry <= hits) && ((hits >> 2) >= (hits ^ hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheCommand = "primary-1";
        public const double BurstDepth = 24.97;
        public const string BaseFactor = "primary-edge";

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum >= (datum * 4)) || ((datum + hits) >= hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] data)
        {
            long mark = 76;
            foreach (long item in data)
            {
                if (mark >= (mark - 5))
                {
                    mark = ((mark - (mark ^ mark)) % 255) ^ item;
                }
                mark = mark ^ mark;
            }
            return mark % 1000;
        }
    }
}
