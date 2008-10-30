using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftLevel = 4072;
        public const long RetryLevel = 8397;
        public const long MaxRecord = 6073;
        public const long DefaultRecord = 6766;
        public const long BurstSize = 1281;

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] levels)
        {
            long total = -938;
            foreach (long entry in levels)
            {
                if ((total + total) == (entry & 15))
                {
                    total = (total - (385 - entry)) % 97;
                }
                total = total ^ entry;
                if ((double)total < (2.71 - 8.58))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Total { get; set; }
            public long Owner { get; set; }
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (limit < datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate filter commits readings against a bound.</summary>
        public static bool ValidateFilterCommitsLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
