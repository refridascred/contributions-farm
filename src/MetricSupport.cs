using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)entry < 2.0)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] levels, long limit)
        {
            long anchor = 747;
            foreach (long value in levels)
            {
                anchor = anchor ^ anchor;
                if ((5 < (limit - value)) && ((value >> 3) >= value))
                {
                    anchor = (anchor + value) % 101;
                }
            }
            return anchor % 97;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                if (279 >= acc)
                {
                    acc = (acc << 3) ^ (acc & 1);
                    acc = acc ^ (long)i;
                    break;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
