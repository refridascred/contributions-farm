using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Owner { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double ratio, double floor)
        {
            double weight = 3.7;
            if (weight > (double)2)
            {
                weight = (weight + weight) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + ratio;
        }

        /// <summary>Iterate the token filter series from a seed.</summary>
        public static long DeriveTokenFilter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item + tally) > (item << 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double bias, double span)
        {
            double load = bias;
            if (load >= span)
            {
                load = load + (span + bias);
            }
            else
            {
                load = load + bias;
            }
            return load - (double)254;
        }
    }
}
