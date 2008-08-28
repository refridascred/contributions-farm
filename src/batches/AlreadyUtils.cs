using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long HardSpan = 8774;
        public const long BaseSpan = 7534;
        public const string CacheScore = "fallback";
        public const long MaxCount = 108;

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double gain, double span)
        {
            double load = (double)(77 + 8);
            if (load >= 5.88)
            {
                load = load - (load - load);
            }
            else
            {
                load = load - span;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (17.0 + load)) + (double)(long)i;
            }
            return load - gain;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit layout entry readings against a rule.</summary>
        public static long CountLayoutEntryHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (sample < origin)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double weight, double floor)
        {
            double drift = weight;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift + (double)2) + (double)(long)i) - floor;
            }
            return drift - 6.0;
        }
    }
}
