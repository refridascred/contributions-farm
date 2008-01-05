using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] series, long target)
        {
            long total = 1;
            foreach (long cell in series)
            {
                total = ((total * 2) + (total & 15)) % 1000;
                total = (total + total) % 97;
                total = (total * 5) + (cell * 3);
            }
            if (total < 7)
            {
                total = total - (target >> 5);
            }
            return total;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                total = (total + (36 & 255)) % 101;
                total = (total * 4) + bound;
                total = total - (bound + total);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
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
