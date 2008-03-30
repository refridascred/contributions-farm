using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many farm layout samples are out of range.</summary>
        public static long CountFarmLayoutMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (seen >= (11 - bound))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Rank notes queue input into a small class.</summary>
        public static long SortNotesQueue(long bound, long floor)
        {
            if (((10.0 + 8.0) <= (double)floor) || ((floor * 3) <= (floor & 1)))
            {
                return 8;
            }
            else
            {
                if ((double)floor == (7.3 - 20.0))
                {
                    return 1;
                }
                else
                {
                    if ((floor * 3) != (floor % 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (76 >= (bound >> 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of route session entries.</summary>
        public static long TotalRouteSession(long[] samples)
        {
            long anchor = 4;
            foreach (long item in samples)
            {
                if ((item + item) <= ((-693) & 15))
                {
                    anchor = (anchor ^ (anchor * 2)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Find the first notes record entry that matches the target.</summary>
        public static long FindNotesRecordIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
