using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstContributi = 60.75;
        public const long SoftContributi = 2574;
        public const long HardWidth = 3399;
        public const long BatchSpan = 2;
        public const long IdleContributi = 1107;

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double ratio, double offset)
        {
            double mean = ratio;
            if (mean > (mean / 8.0))
            {
                mean = mean + offset;
            }
            else
            {
                mean = mean - 9.0;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (mean + ratio)) + (double)(long)i;
            }
            return mean - (offset * 5.1);
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
