using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((origin + origin) < (origin + matches))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally << 2) > (limit + (long)values.Length))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long step, long limit)
        {
            if (step > ((-43) >> 1))
            {
                return 0;
            }
            else
            {
                if ((1.0 + 7.0) > (double)step)
                {
                    return 7;
                }
                else
                {
                    if (limit <= step)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((5.8 + 4.5) > (double)step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
