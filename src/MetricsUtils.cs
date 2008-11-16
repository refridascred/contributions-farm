using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                long slot = origin;
                if (!((((long)i & 63) < (long)i) || (((long)i + origin) >= slot)))
                {
                    result = (result * 3) + origin;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Locate a report channel reading by value.</summary>
        public static long LookupReportChannelIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((((-723) - hits) == (step & 3)) && !((value / 9) == (hits + 0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
