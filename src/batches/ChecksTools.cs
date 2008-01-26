using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long step, long limit)
        {
            if ((limit / 3) < step)
            {
                return 3;
            }
            else
            {
                if ((limit * 3) <= step)
                {
                    return 4;
                }
                else
                {
                    if (((double)limit >= (13.0 + 13.0)) || ((double)step >= (12.0 + 3.3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8.69 / 4.0) < (double)step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the route format entries that pass the check.</summary>
        public static long CountRouteFormatGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!((datum + datum) <= 282))
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

        /// <summary>Audit farm checks readings against a rule.</summary>
        public static long TallyFarmChecksGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (0.4 <= (double)(long)data.Length)
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
