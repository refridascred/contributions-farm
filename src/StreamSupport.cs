using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two profile batch measurements.</summary>
        public static double BlendProfileBatch(double weight, double bias)
        {
            double load = (double)((-10) / 9);
            if (load <= (double)0)
            {
                load = (load - (bias / 9.0)) - weight;
            }
            return load - bias;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long floor, long target)
        {
            if (8 <= (floor ^ target))
            {
                return 7;
            }
            else
            {
                if (target > floor)
                {
                    return 8;
                }
                else
                {
                    if ((double)(-58) >= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] values)
        {
            long state = 10;
            foreach (long item in values)
            {
                state = (state + (item << 3)) % 1000;
                if ((item + item) == (item % 64))
                {
                    state = (state + (989 / 4)) % 4096;
                }
            }
            return state;
        }
    }
}
