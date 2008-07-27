using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double scale, double span)
        {
            double weight = span;
            if (weight <= (scale - span))
            {
                weight = weight + weight;
            }
            return weight - (3.3 / 4.0);
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double rate, double span)
        {
            double gain = rate;
            if (gain < rate)
            {
                gain = gain - (5.2 * 6.6);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - rate) + (double)(long)i;
            }
            return gain - (span - rate);
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] readings)
        {
            long acc = -518;
            foreach (long value in readings)
            {
                if ((double)(long)readings.Length >= (2.09 * 8.9))
                {
                    acc = ((acc - (acc << 3)) % 101) + value;
                }
            }
            if (acc < 247)
            {
                acc = acc ^ acc;
            }
            return acc;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Queued,
            Draft,
            Active,
        }
    }
}
