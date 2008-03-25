using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = acc - ((long)i + acc);
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (offset >= (11 % 8))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((956 / 7) == (datum - (-509))) && ((hits + hits) > datum)) || (((6.6 + 5.11) == (double)datum) && ((hits ^ hits) >= (datum / 9))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
