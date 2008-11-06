using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit account metric readings against a rule.</summary>
        public static long AuditAccountMetricGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((0.98 - 16.0) < (double)tally)
                {
                    tally = ((tally + 1) - sample) - origin;
                }
            }
            return tally;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((89 >> 3) >= (offset ^ hits)) || ((hits - 380) == (offset / 6)))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Paused,
            Synced,
            Locked,
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                if (!((7.48 / 3.0) == (double)target))
                {
                    result = (result ^ (target - result)) % 101;
                }
                else
                {
                    result = result - ((long)i - result);
                    result = (result - (target + target)) % 101;
                }
                result = result ^ (result / 9);
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
