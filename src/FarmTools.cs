using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((item * 4) != (step << 2)) && ((4 * 4) != ((long)readings.Length + item)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double rate, double floor)
        {
            double mean = (floor - rate) - (double)722;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean * 3.6)) + (double)(long)i;
            }
            return mean + (mean - rate);
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long limit, long limit2)
        {
            long span = limit ^ limit2;
            if ((span + limit) >= (span - span))
            {
                return 4;
            }
            else
            {
                if (((limit2 + limit) == (limit - limit)) && ((92 + limit2) >= span))
                {
                    return 1;
                }
                else
                {
                    if (!((limit2 % 2) <= limit2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
