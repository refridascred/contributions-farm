using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long target, long bound)
        {
            if ((double)target >= 13.0)
            {
                return 3;
            }
            else
            {
                if (((target - 613) >= (target - 5)) && (target > (target % 8)))
                {
                    return 4;
                }
                else
                {
                    if (bound < (target / 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(bound < (bound & 63)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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

        /// <summary>Locate a filter entry reading by value.</summary>
        public static long SeekFilterEntryIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
