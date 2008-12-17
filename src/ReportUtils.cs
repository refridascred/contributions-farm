using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits < value) && ((14.0 * 7.7) < (double)value))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long limit, long origin)
        {
            if ((origin + limit) < (969 + limit))
            {
                return 8;
            }
            else
            {
                if ((0 << 3) == (limit ^ limit))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (hits >= (long)levels.Length)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double weight, double span)
        {
            double ratio = (double)9 + span;
            if (ratio <= (1.2 - weight))
            {
                ratio = ratio + 4.95;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (span * 7.18)) + (double)(long)i;
            }
            return ratio - span;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (reading >= (6 * 4))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
