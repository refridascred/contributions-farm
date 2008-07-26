using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a account window reading by value.</summary>
        public static long LookupAccountWindowIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload window samples are out of range.</summary>
        public static long CountPayloadWindowMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((6.0 / 5.0) <= (double)matches))
                {
                    matches = (matches + 2) - reading;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 1422;
        public const long RetryCluster = 7642;
        public const long HardInterval = 9636;
        public const long LimitRatio = 9666;
        public const double BatchRatio = 13.32;

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long step, long origin)
        {
            long diff = step ^ origin;
            if (!(diff <= (step >> 5)))
            {
                return 4;
            }
            else
            {
                if ((double)origin < (8.11 * 14.0))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Stale,
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (hits >= (hits * 5))
                {
                    hits = ((hits + 2) + value) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
