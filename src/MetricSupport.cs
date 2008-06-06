using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up token layout samples.</summary>
        public static long MatchTokenLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the format metric series from a seed.</summary>
        public static long DeriveFormatMetric(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark - (limit - 871)) % 4096;
                if ((4.51 * 9.0) == (double)limit)
                {
                    mark = (mark + (limit - limit)) % 4096;
                    mark = mark - (limit << 2);
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 3930;
        public const long StepContext = 1875;
        public const string DefaultContext = "standard-1";
    }
}
