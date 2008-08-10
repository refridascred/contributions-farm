using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every already entry entry stays within the limit.</summary>
        public static bool CheckAlreadyEntryLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((((tally + 909) < value) && ((step << 1) > ((-743) * 2))) || (((-81) ^ tally) > (tally * 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema stream readings against a rule.</summary>
        public static long MeasureSchemaStreamHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((long)readings.Length == (datum + (-745)))
                {
                    seen = (seen + 1) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((sum + sum) >= (sum + limit))
                {
                    sum = sum - limit;
                }
                else
                {
                    sum = sum + (24 + sum);
                }
                if ((limit + 434) <= (sum >> 3))
                {
                    sum = (sum * 3) + ((-412) ^ sum);
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
