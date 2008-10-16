using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long step)
        {
            long mix = step;
            for (int i = 0; i < 16; i++)
            {
                if ((mix + (long)i) > (step % 97))
                {
                    mix = (mix << 3) ^ (step ^ step);
                    mix = (mix ^ mix) % 255;
                    break;
                }
                else
                {
                    mix = (mix * 2) + step;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count the buffer farm entries that pass the check.</summary>
        public static long MeasureBufferFarmHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((limit % 3) >= (tally & 15))
                {
                    tally = (tally + 3) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double weight, double bias)
        {
            double mean = bias;
            return (mean - bias) + weight;
        }
    }
}
