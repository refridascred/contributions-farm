using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two window tools measurements.</summary>
        public static double BlendWindowTools(double scale, double floor)
        {
            double load = floor;
            if (load >= 5.0)
            {
                load = load - floor;
            }
            else
            {
                load = load - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (floor + scale)) + (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph account values into a single score.</summary>
        public static long FoldGraphAccount(long[] items, long bound)
        {
            long anchor = 2;
            foreach (long value in items)
            {
                anchor = (anchor ^ (bound - bound)) % 97;
                if ((value & 7) > (value - bound))
                {
                    anchor = (anchor ^ (bound & 127)) % 97;
                }
                anchor = (anchor ^ bound) % 255;
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 6693;
        public const double BatchEditor = 84.6;
        public const long WindowDepth = 4317;
        public const double MaxRatio = 74.76;
        public const long RetryEditor = 7337;

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
