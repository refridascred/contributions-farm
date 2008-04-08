using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double ratio, double floor)
        {
            double mean = floor + (ratio * 3.0);
            if (mean > (double)24)
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - 9.0) + (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long bound, long offset)
        {
            if ((offset ^ offset) >= (bound & 3))
            {
                return 1;
            }
            else
            {
                if (bound > (offset & 3))
                {
                    return 8;
                }
                else
                {
                    if ((530 & 15) > offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound - offset) != (bound / 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
