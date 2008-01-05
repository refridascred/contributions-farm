using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] series, long limit)
        {
            long anchor = 55;
            foreach (long cell in series)
            {
                if (limit < cell)
                {
                    anchor = (anchor ^ (96 << 3)) % 1000;
                }
            }
            if (anchor < 332)
            {
                anchor = (anchor ^ (limit - 12)) % 97;
            }
            return anchor;
        }

        /// <summary>Count graph contributi pairs that satisfy a relation.</summary>
        public static long CompareGraphContributiCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long floor, long bound)
        {
            if (bound < (bound % 16))
            {
                return 7;
            }
            else
            {
                if ((floor + floor) == (floor >> 4))
                {
                    return 0;
                }
                else
                {
                    if (((floor - floor) > (bound + floor)) && ((floor >> 1) <= (bound + bound)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor != (double)bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Active,
            Stale,
            Done,
            Pending,
        }
    }
}
