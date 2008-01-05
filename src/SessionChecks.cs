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

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportRange(long[] series, long step)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double ratio, double floor)
        {
            double drift = ratio;
            if (drift > (double)100)
            {
                drift = drift + (drift + drift);
            }
            else
            {
                drift = drift - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (double)21) + (double)(long)i;
            }
            return drift + (double)1;
        }
    }
}
