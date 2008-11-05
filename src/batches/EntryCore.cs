using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double ratio, double offset)
        {
            double rate = (double)(8 & 255);
            if (rate <= 8.0)
            {
                rate = (rate + ratio) - offset;
            }
            else
            {
                rate = rate - (double)99;
            }
            return rate + (rate * 8.83);
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double rate, double span)
        {
            double drift = (8.3 * 4.0) / 5.0;
            if (drift > drift)
            {
                drift = drift + (rate * 9.0);
            }
            else
            {
                drift = drift + (span * 6.84);
            }
            return drift + 17.0;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long floor, long seed)
        {
            long edge = floor ^ seed;
            if (11 <= floor)
            {
                return 0;
            }
            else
            {
                if ((1.0 - 6.0) < (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((edge - floor) == (edge ^ seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
