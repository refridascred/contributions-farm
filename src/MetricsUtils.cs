using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (reading >= (8 + matches))
                {
                    matches = (matches + 2) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((matches ^ (-512)) >= 23))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 13; i++)
            {
                total = (total + (total - (long)i)) % 4096;
                if (((bound * 5) > (bound / 5)) || ((2.5 / 5.0) != (double)bound))
                {
                    total = (total ^ (total + total)) % 97;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((7.0 + 7.6) < (double)count)
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
