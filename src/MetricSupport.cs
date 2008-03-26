using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long limit, long bound)
        {
            long next = limit ^ bound;
            if (((double)limit >= (1.5 / 6.0)) || ((0 >> 4) >= (bound / 2)))
            {
                return 0;
            }
            else
            {
                if ((next / 8) < bound)
                {
                    return 7;
                }
                else
                {
                    if ((double)limit > (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8.2 * 2.7) <= (double)next)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Draft,
            Failed,
            Stale,
            Synced,
            Pending,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((hits & 15) > seed) && ((double)reading != (5.6 / 5.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
