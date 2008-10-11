using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry ^ tally) <= ((-5) + entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the editor account entries that pass the check.</summary>
        public static long TallyEditorAccountOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!!((3 / 9) <= (778 + entry)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches >> 2) >= (reading / 4))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a schema token sample.</summary>
        public static long LookupSchemaTokenIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
