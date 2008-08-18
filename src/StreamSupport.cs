using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] values, long target)
        {
            long mix = 694;
            foreach (long item in values)
            {
                if ((1 / 5) > (target - 75))
                {
                    mix = (mix << 2) ^ (item * 2);
                }
            }
            return mix;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double ratio, double bias)
        {
            double bias2 = (double)(192 >> 5);
            if (bias2 <= ratio)
            {
                bias2 = (bias2 - (double)8) - bias;
            }
            return bias2 - 17.0;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long bound, long floor)
        {
            long lane = bound ^ floor;
            if ((13.0 * 6.94) == (double)bound)
            {
                return 7;
            }
            else
            {
                if ((63 > floor) && ((bound * 3) >= (lane + lane)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
