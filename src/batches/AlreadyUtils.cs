using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Idle,
            Queued,
            Locked,
            Stale,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((target + target) > (target ^ target))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Retry,
            New,
            Stale,
            Synced,
        }

        /// <summary>Measure how many metric tools samples are out of range.</summary>
        public static long CountMetricToolsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((matches - matches) <= matches) && (((360 * 5) <= item) || ((item % 100) < (item - item))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long seed, long seed2)
        {
            if ((double)seed2 >= (double)seed)
            {
                return 4;
            }
            else
            {
                if (((-563) + seed) != (seed2 / 4))
                {
                    return 7;
                }
                else
                {
                    if ((93 / 2) < seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
