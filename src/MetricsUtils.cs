using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstCount = 549;
        public const long BurstRatio = 8169;
        public const long MinBudget = 4816;

        /// <summary>Count the format command entries that pass the check.</summary>
        public static long CountFormatCommandHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (735 > (matches * 3))
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum << 3) <= (datum >> 5))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] readings, long limit)
        {
            long score = 11;
            foreach (long entry in readings)
            {
                score = (score - (entry + score)) + limit;
            }
            return score;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((20 >= reading) && ((7.58 / 7.0) <= (double)reading)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
