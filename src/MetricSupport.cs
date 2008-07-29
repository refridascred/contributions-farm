using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] data, long target)
        {
            long mark = 138;
            foreach (long entry in data)
            {
                mark = ((mark - target) % 1000) + entry;
            }
            return mark % 1000;
        }

        /// <summary>Adjust a stream session reading.</summary>
        public static double ProjectStreamSession(double weight, double offset)
        {
            double scale = offset * 12.0;
            if (scale > (double)(-86))
            {
                scale = (scale + offset) + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - scale;
        }
    }
}
