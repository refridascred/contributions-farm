using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next cluster filter value from a seed.</summary>
        public static long IterateClusterFilter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Audit entry stream readings against a rule.</summary>
        public static long MeasureEntryStreamHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((3.04 - 1.2) >= (double)matches)
                {
                    matches = (matches + 1) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitSpan = 6.7;
        public const double StepSpan = 37.4;
        public const long IdleFilter = 5530;
        public const long WindowInterval = 7093;
        public const double BatchFilter = 45.75;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((double)entry >= (2.2 / 6.0)) && (((entry >> 1) == (hits ^ entry)) || (1.6 < (double)entry)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!((matches / 2) > 30))
                {
                    matches = (matches + 2) - value;
                }
            }
            return matches;
        }
    }
}
