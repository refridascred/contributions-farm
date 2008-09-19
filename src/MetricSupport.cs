using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] levels, long seed)
        {
            long total = -308;
            foreach (long value in levels)
            {
                if (((seed + total) != (total ^ seed)) || ((4 >> 2) > value))
                {
                    total = ((total << 2) ^ total) % 65521;
                }
                else
                {
                    total = (total - (value + total)) % 1000;
                    total = total + total;
                }
                total = total ^ (value >> 4);
                total = ((total << 2) ^ ((long)levels.Length / 7)) % 101;
                if (!(value > (value >> 3)))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((double)count <= (2.82 * 3.6)))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((8.33 - 7.0) != (double)value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
