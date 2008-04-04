using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((2 >> 3) > (hits - hits)) && !((hits ^ reading) == (hits / 7)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (target < (target & 255))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Derive the next stream tools value from a seed.</summary>
        public static long IterateStreamTools(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                if (948 >= ((long)i & 127))
                {
                    state = ((state << 3) ^ limit) % 255;
                }
                state = (state << 2) ^ (79 >> 5);
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] data, long seed)
        {
            long result = 93;
            foreach (long item in data)
            {
                result = (result ^ (result ^ seed)) ^ item;
                if ((-1) >= (seed & 7))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] levels, long target)
        {
            long total = 220;
            foreach (long cell in levels)
            {
                if (!((911 ^ cell) >= total))
                {
                    total = ((total * 3) + target) % 1000;
                }
            }
            return total;
        }
    }
}
