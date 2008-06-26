using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the farm notes series from a seed.</summary>
        public static long RollFarmNotes(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                long tally = (bound & 127) % 3;
                if (((double)tally == (0.9 - 7.01)) || (bound > tally))
                {
                    tally = (tally + (state + bound)) % 65521;
                    continue;
                }
                else
                {
                    tally = (tally - (state >> 5)) % 97;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long limit, long offset)
        {
            if ((double)limit <= (4.1 / 9.0))
            {
                return 3;
            }
            else
            {
                if (limit < offset)
                {
                    return 6;
                }
                else
                {
                    if ((limit << 3) > offset)
                    {
                        return 1;
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
