using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((double)(long)levels.Length < 8.4))
                {
                    tally = ((tally + 1) + reading) - target;
                }
            }
            return tally;
        }

        /// <summary>Audit metric channel readings against a rule.</summary>
        public static long AuditMetricChannelGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((double)sample == (double)hits) || (sample >= (hits + hits)))
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell - tally) >= (tally ^ 69))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits / 2) <= target)
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }
    }
}
