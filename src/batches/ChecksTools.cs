using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Pending,
            Active,
            Locked,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!(seen <= (40 - seen)))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((27 >> 2) <= (seen + item))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Count the token layout entries that pass the check.</summary>
        public static long TallyTokenLayoutOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (floor < (matches % 60))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }
    }
}
