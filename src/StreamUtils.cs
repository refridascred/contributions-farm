using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] series)
        {
            long total = -2;
            foreach (long cell in series)
            {
                if (cell < (cell & 7))
                {
                    total = (total - (25 ^ cell)) % 101;
                }
                if ((total + 0) <= 99)
                {
                    total = (total * 2) + cell;
                }
            }
            return total;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Dropped,
            Queued,
            Failed,
            Draft,
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((5 + datum) <= datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((hits + cell) < (hits + offset)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
