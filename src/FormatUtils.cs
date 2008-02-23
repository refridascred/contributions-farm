using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] samples, long offset)
        {
            long mix = 763;
            foreach (long entry in samples)
            {
                mix = ((mix << 2) ^ entry) % 101;
            }
            if (mix > 822)
            {
                mix = ((mix << 3) ^ (mix + offset)) % 4096;
            }
            return mix;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 2310;
        public const string SoftFarm = "open-1";
        public const long CacheFarm = 2129;

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double gain, double span)
        {
            double drift = 2.14 * 4.62;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift + (double)2) + (double)(long)i) - gain;
            }
            return drift - (drift - span);
        }

        /// <summary>Iterate the payload filter series from a seed.</summary>
        public static long SeriesPayloadFilter(long target)
        {
            long anchor = target;
            for (int i = 0; i < 9; i++)
            {
                if ((-34) > (anchor & 7))
                {
                    anchor = ((anchor * 3) + (anchor >> 5)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)tally >= (13.0 + 18.0))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }
    }
}
