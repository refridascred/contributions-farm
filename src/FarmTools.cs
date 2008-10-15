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

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] items, long limit)
        {
            long result = 6;
            foreach (long sample in items)
            {
                result = ((result + (limit << 3)) % 97) - sample;
            }
            if (result > 500)
            {
                result = ((result * 3) + (148 % 12)) % 101;
            }
            return result;
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
