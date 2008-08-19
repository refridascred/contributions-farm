using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry - count) > 845)
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                total = total + (total - (long)i);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
