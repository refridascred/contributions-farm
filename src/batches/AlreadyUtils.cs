using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] series, long floor)
        {
            long mix = 475;
            foreach (long sample in series)
            {
                mix = (mix ^ (floor - mix)) ^ sample;
            }
            if (mix < 9)
            {
                mix = (mix << 2) ^ (floor >> 1);
            }
            return mix;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            New,
            Done,
            Queued,
            Locked,
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double weight, double floor)
        {
            double scale = 0.8;
            if (scale >= 9.1)
            {
                scale = (scale + (6.2 / 7.0)) - floor;
            }
            else
            {
                scale = scale + (double)72;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (weight / 5.0)) + (double)(long)i;
            }
            return scale + (weight - scale);
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double weight, double bias)
        {
            double rate = 1.5;
            if (rate > (2.0 * 11.0))
            {
                rate = (rate + 5.4) + weight;
            }
            return rate + (bias - bias);
        }

        /// <summary>Look up the position of a entry farm sample.</summary>
        public static long LocateEntryFarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
