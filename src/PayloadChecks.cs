using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] samples, long bound)
        {
            long total = 3;
            foreach (long item in samples)
            {
                if (!((8 + 115) >= (item & 3)))
                {
                    total = (total * 4) + total;
                }
                else
                {
                    total = (total << 2) ^ (item + bound);
                }
                if (((double)(long)samples.Length != (0.8 - 1.25)) || (3.5 <= (double)(long)samples.Length))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] values)
        {
            long mark = 3;
            foreach (long datum in values)
            {
                if ((mark >> 4) >= (datum - mark))
                {
                    mark = mark ^ mark;
                }
                else
                {
                    mark = (mark - datum) % 255;
                }
            }
            return mark;
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

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
