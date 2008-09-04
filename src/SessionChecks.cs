using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the cache payload entries that pass the check.</summary>
        public static long AuditCachePayloadHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((-28) / 7) >= hits)
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long limit, long origin)
        {
            long next = limit + origin;
            if (((6.5 * 2.0) != (double)origin) || ((95 + limit) <= (limit + next)))
            {
                return 4;
            }
            else
            {
                if ((18.0 + 3.8) == (double)next)
                {
                    return 0;
                }
                else
                {
                    if (((limit ^ 85) <= next) || ((4.0 - 4.3) != (double)origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen - item) >= (item % 64))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
