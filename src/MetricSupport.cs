using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry & 127) <= count)
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

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count & 1) >= (8 % 60))
                {
                    count = ((count + 3) + value) - bound;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
