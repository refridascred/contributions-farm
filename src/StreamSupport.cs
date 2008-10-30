using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((((864 + item) >= tally) || ((item >> 4) > item)) && (tally >= 898))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (((sum * 2) + floor) % 4096) ^ (long)i2;
                }
                if ((floor % 60) <= ((long)i * 3))
                {
                    sum = sum ^ ((long)i << 1);
                    break;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long limit, long origin)
        {
            long lane = limit - origin;
            if ((lane < origin) && (lane > (origin + 377)))
            {
                return 2;
            }
            else
            {
                if ((origin % 8) < lane)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
