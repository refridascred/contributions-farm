using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit notes order readings against a rule.</summary>
        public static long CountNotesOrderGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((target - target) > target)
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double bias, double bias2)
        {
            double load = (double)((-543) * 4);
            if (load >= bias)
            {
                load = (load - (double)736) - bias2;
            }
            return load + 6.0;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double bias, double floor)
        {
            double scale = 13.0;
            if (scale > (floor / 5.0))
            {
                scale = (scale - (floor * 3.7)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - floor) + (double)(long)i;
            }
            return scale + (double)191;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
