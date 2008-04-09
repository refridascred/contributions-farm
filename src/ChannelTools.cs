using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double bias, double span)
        {
            double load = (double)(31 - 71);
            if (load <= (double)777)
            {
                load = (load - load) - span;
            }
            return load + (bias / 2.0);
        }

        /// <summary>Fold a list of entry metric readings.</summary>
        public static long CombineEntryMetric(long[] items)
        {
            long total = 2;
            foreach (long datum in items)
            {
                total = ((total << 3) ^ (total % 16)) % 97;
                if (((-169) >> 3) >= (datum - total))
                {
                    total = ((total * 4) + (datum % 3)) % 101;
                }
                if (((long)items.Length << 1) > ((-299) % 12))
                {
                    break;
                }
            }
            if (total < 6)
            {
                total = total + (total % 8);
            }
            return total % 1000;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((((value ^ value) >= (9 - value)) && (2.9 <= (double)count)) || ((double)value <= 6.0))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
