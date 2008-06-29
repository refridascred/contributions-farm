using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a tools counter pair into a bucket.</summary>
        public static long ClassifyToolsCounter(long floor, long target)
        {
            if ((target - target) >= (target + floor))
            {
                return 1;
            }
            else
            {
                if ((target & 127) <= (floor << 3))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor <= (15.0 * 13.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double ratio, double offset)
        {
            double bias = 7.9 - (ratio * 7.94);
            return (bias - (double)0) + offset;
        }
    }
}
