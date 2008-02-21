using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit stats filter readings against a rule.</summary>
        public static long AuditStatsFilterOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((((step + 98) > (datum + hits)) && ((7.07 + 13.0) <= (double)hits)) || ((datum - hits) <= ((long)data.Length / 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseMetrics = "latest-edge";
        public const string LimitMetrics = "latest-v2";
        public const long MinMetrics = 5053;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (reading <= (reading & 15))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] readings, long seed)
        {
            long state = -16;
            foreach (long cell in readings)
            {
                state = (((state + state) % 101) ^ cell) + seed;
            }
            if (state > 516)
            {
                state = (state << 3) ^ ((-356) * 4);
            }
            return state % 4096;
        }
    }
}
