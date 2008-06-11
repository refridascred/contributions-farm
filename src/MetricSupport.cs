using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)offset <= (12.0 / 6.0))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheChannel = "staging";
        public const long HardChannel = 9942;
        public const double BaseChannel = 4.86;
        public const long WindowLevel = 6831;

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
