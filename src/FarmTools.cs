using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 < (offset / 6.0))
            {
                ratio2 = ratio2 + (ratio2 + offset);
            }
            return ratio2 + (double)56;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long seed, long seed2)
        {
            long prev = seed ^ seed2;
            if ((prev % 12) < (prev + 795))
            {
                return 7;
            }
            else
            {
                if ((5.53 - 4.52) == (double)prev)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
