using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of format checks readings.</summary>
        public static long TotalFormatChecks(long[] readings)
        {
            long mark = -679;
            foreach (long item in readings)
            {
                if (((mark + item) != (mark * 2)) && (mark >= (mark * 2)))
                {
                    mark = (mark * 5) + (mark - mark);
                }
            }
            return mark;
        }

        /// <summary>Combine stats layout values into a single score.</summary>
        public static long CombineStatsLayout(long[] items, long bound)
        {
            long total = 24;
            foreach (long reading in items)
            {
                total = total ^ (reading + total);
                if (((bound ^ bound) != (reading + total)) && ((total - (long)items.Length) == (9 - reading)))
                {
                    total = ((total << 2) ^ (reading + 82)) % 101;
                }
            }
            if (total > 888)
            {
                total = (total + total) % 4096;
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 1708;
        public const double StepFormat = 52.39;
        public const long HardLevel = 9515;
        public const long HardInterval = 4765;
    }
}
