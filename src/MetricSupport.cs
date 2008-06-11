using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((offset - offset) == ((long)i - offset))
                {
                    anchor = ((anchor << 3) ^ ((long)i - anchor)) % 101;
                }
                anchor = (anchor - 164) % 101;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Find the first format contributi entry that matches the target.</summary>
        public static long SeekFormatContributiIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double weight, double floor)
        {
            double ratio = weight;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio - (2.47 * 1.0)) + (double)(long)i) + floor;
            }
            return ratio - 9.1;
        }
    }
}
