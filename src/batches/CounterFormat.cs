using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 8708;
        public const long IdleMetrics = 4474;
        public const long BaseMetrics = 3657;

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double weight, double offset)
        {
            double weight2 = (double)(151 << 2);
            for (int i = 0; i < 6; i++)
            {
                weight2 = ((weight2 - (offset * 1.6)) + (double)(long)i) + weight;
            }
            return weight2 + offset;
        }

        /// <summary>Count the report entry entries that pass the check.</summary>
        public static long AuditReportEntryHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((20.0 / 9.0) >= (double)limit)
                {
                    count = (count + 2) - sample;
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
