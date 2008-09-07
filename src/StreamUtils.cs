using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of filter metric readings.</summary>
        public static long WeighFilterMetric(long[] series)
        {
            long result = 84;
            foreach (long item in series)
            {
                if ((item % 16) <= (result + item))
                {
                    result = result - (66 >> 1);
                }
                else
                {
                    result = (result << 2) ^ item;
                }
            }
            return result;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((step + sample) >= (23 - tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((hits ^ hits) != ((-374) * 5)) && ((item >= (hits << 1)) || ((item + item) >= (2 % 5))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits + hits) < cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks counter samples are out of range.</summary>
        public static long TallyChecksCounterHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((5.3 * 2.0) > (double)seen)
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }
    }
}
