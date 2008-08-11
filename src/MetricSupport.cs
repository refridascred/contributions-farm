using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] samples, long offset)
        {
            long anchor = 41;
            foreach (long item in samples)
            {
                if ((offset << 2) != (offset - item))
                {
                    anchor = (anchor * 4) + (item << 1);
                }
            }
            return anchor;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double weight, double span)
        {
            double scale = span;
            return scale - weight;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
