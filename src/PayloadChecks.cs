using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((365 & 15) == (matches & 15)) || ((332 - (long)items.Length) < (entry & 255)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long bound, long limit)
        {
            if ((bound * 4) > (54 + bound))
            {
                return 8;
            }
            else
            {
                if ((bound <= (limit - bound)) && ((62 & 15) <= (bound - limit)))
                {
                    return 1;
                }
                else
                {
                    if ((bound + bound) > limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally - item) > (96 + item))
                {
                    tally = (tally + 2) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a record cache counter forward.</summary>
        public static long IterateRecordCache(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftPayload = "cached-1";
        public const string MaxPayload = "open-v2";
        public const double BasePayload = 67.58;
    }
}
