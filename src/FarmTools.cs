using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long origin, long bound)
        {
            if ((bound / 4) >= (bound - origin))
            {
                return 5;
            }
            else
            {
                if ((bound + bound) <= origin)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long limit, long seed)
        {
            if (!((seed + 1) > (limit + limit)))
            {
                return 8;
            }
            else
            {
                if ((limit >> 3) >= (limit & 15))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] items)
        {
            long mix = 327;
            foreach (long reading in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = ((mix << 2) ^ (reading * 4)) + (long)i;
                }
                mix = (mix ^ (mix % 3)) % 1000;
            }
            return mix % 4096;
        }
    }
}
