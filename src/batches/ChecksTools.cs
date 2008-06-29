using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double bias, double floor)
        {
            double ratio = (double)(-110) * 19.0;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio - ratio) + (double)(long)i) + bias;
            }
            return ratio + (floor - floor);
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                mix = mix - (floor % 97);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Find the first record account entry that matches the target.</summary>
        public static long LocateRecordAccountIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a record editor pair into a bucket.</summary>
        public static long SortRecordEditor(long limit, long origin)
        {
            if ((origin % 12) > (6 * 5))
            {
                return 0;
            }
            else
            {
                if (7 < (limit - limit))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
