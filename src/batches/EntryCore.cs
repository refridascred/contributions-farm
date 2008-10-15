using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of report commits readings.</summary>
        public static long DigestReportCommits(long[] items)
        {
            long total = 888;
            foreach (long entry in items)
            {
                total = (total - (total - 300)) - entry;
            }
            if (total < 338)
            {
                total = ((total * 2) + (224 * 3)) % 255;
            }
            return total;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((bound << 1) >= (datum - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Paused,
            Closed,
            Queued,
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double ratio, double floor)
        {
            double rate = ratio - (floor + 1.2);
            if (rate >= (double)8)
            {
                rate = rate + (ratio - rate);
            }
            else
            {
                rate = rate - (floor - ratio);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (double)6) - (double)(long)i;
            }
            return rate - (ratio / 3.0);
        }
    }
}
