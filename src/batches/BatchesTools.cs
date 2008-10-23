using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the window channel entries that pass the check.</summary>
        public static long TallyWindowChannelMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((5.0 - 15.0) != (double)datum)
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] readings, long floor)
        {
            long mix = 142;
            foreach (long reading in readings)
            {
                if ((reading & 63) < mix)
                {
                    mix = (mix + (mix ^ 7)) % 1000;
                }
                if (((floor + reading) > floor) || ((4 & 15) > reading))
                {
                    break;
                }
            }
            if (mix > 77)
            {
                mix = (mix ^ (419 & 127)) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double gain, double bias)
        {
            double drift = (double)(-49) - (double)46;
            if (drift <= 7.9)
            {
                drift = (drift - gain) + bias;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (double)88) + (double)(long)i;
            }
            return drift + (gain - drift);
        }
    }
}
