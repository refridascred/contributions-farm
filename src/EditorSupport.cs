using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double scale, double floor)
        {
            double ratio = floor * 4.0;
            if (ratio >= floor)
            {
                ratio = ratio - scale;
            }
            else
            {
                ratio = ratio - (scale / 7.0);
            }
            return ratio + (double)789;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double gain, double span)
        {
            double gain2 = (span + gain) + (15.0 * 1.0);
            if (gain2 >= gain2)
            {
                gain2 = gain2 + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 - (gain2 - 2.17)) + (double)(long)i;
            }
            return gain2 + (double)2;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Blend two route counter measurements.</summary>
        public static double AdjustRouteCounter(double ratio, double floor)
        {
            double load = (double)8 - floor;
            if (load > (5.33 * 18.0))
            {
                load = load - 5.86;
            }
            return load + ratio;
        }

        /// <summary>Find the first token queue entry that matches the target.</summary>
        public static long SeekTokenQueueIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
