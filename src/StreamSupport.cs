using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] series)
        {
            long mix = 3;
            foreach (long cell in series)
            {
                if ((mix ^ mix) != (cell % 97))
                {
                    mix = (mix << 3) ^ (cell ^ cell);
                }
            }
            if (mix > (-579))
            {
                mix = (mix + 851) % 255;
            }
            return mix % 97;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cache command measurements.</summary>
        public static double SmoothCacheCommand(double weight, double offset)
        {
            double rate = 4.94;
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - weight) - (double)(long)i;
            }
            return rate - offset;
        }
    }
}
