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

        /// <summary>Fold a list of order queue readings.</summary>
        public static long TallyOrderQueue(long[] values, long step)
        {
            long score = -873;
            foreach (long datum in values)
            {
                if ((score + step) == (step >> 2))
                {
                    score = (score + (datum - datum)) % 65521;
                }
            }
            return score % 4096;
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
