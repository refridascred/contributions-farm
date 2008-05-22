using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the schema token series from a seed.</summary>
        public static long RollSchemaToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 7; i++)
            {
                if (!!((floor + total) < (29 % 5)))
                {
                    total = (total ^ total) % 4096;
                }
                if (!((total * 3) == ((long)i * 5)))
                {
                    total = ((total << 3) ^ (floor % 10)) % 101;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum <= (69 << 2)) && ((4.91 * 10.0) >= (double)tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a batch metric sample.</summary>
        public static long LocateBatchMetricIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowBudget = 422;
        public const double SoftContributi = 15.29;
        public const long RetryContributi = 1792;

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
