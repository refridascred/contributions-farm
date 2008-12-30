using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long seed, long limit)
        {
            if ((seed ^ (-119)) <= (limit + limit))
            {
                return 0;
            }
            else
            {
                if (1 >= (limit >> 5))
                {
                    return 3;
                }
                else
                {
                    if (seed >= (2 % 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                if (!((result + (long)i) <= (11 / 7)))
                {
                    result = (result << 2) ^ 6;
                    result = (result + ((-62) % 16)) % 97;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((matches <= (matches << 1)) || ((matches % 7) <= ((-430) % 3))) && (((double)matches <= (13.0 + 18.0)) || (((long)readings.Length & 127) <= 91)))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((value >> 3) < (seed % 24)) && ((value + matches) == (seed + seed)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((reading + (long)readings.Length) > reading) || ((reading ^ reading) > hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
