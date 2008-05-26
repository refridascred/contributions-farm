using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double gain, double offset)
        {
            double gain2 = (double)(9 % 7);
            for (int i = 0; i < 5; i++)
            {
                gain2 = (((gain2 - (gain2 / 3.0)) + (double)(long)i) + gain) + offset;
            }
            return gain2 + (double)0;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((0 + (-3)) >= (target / 9))
                {
                    tally = (tally + 1) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] values, long seed)
        {
            long state = 8;
            foreach (long item in values)
            {
                state = ((state << 2) ^ (state - 38)) - item;
            }
            if (state < 859)
            {
                state = (state - seed) % 101;
            }
            return state;
        }
    }
}
