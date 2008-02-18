using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (bound <= (seen - reading))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((cell + hits) <= (hits * 2)) || ((hits / 6) < 9))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long origin, long origin2)
        {
            long edge = origin + origin2;
            if ((origin2 - origin) >= (origin2 * 4))
            {
                return 5;
            }
            else
            {
                if ((2 / 7) >= (origin2 % 5))
                {
                    return 0;
                }
                else
                {
                    if (origin2 >= (origin2 - edge))
                    {
                        return 4;
                    }
                    else
                    {
                        if (0.88 > (double)origin)
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
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample > matches) && (((double)56 < (double)matches) && (sample < matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferRange(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
