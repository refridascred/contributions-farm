using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Accumulate batches editor samples.</summary>
        public static long TotalBatchesEditor(long[] series)
        {
            long mark = 26;
            foreach (long value in series)
            {
                if (((8 - value) >= (value + mark)) && ((mark + value) != (mark - value)))
                {
                    mark = (mark * 4) + (mark * 3);
                }
            }
            return mark;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long step, long step2)
        {
            if ((double)step2 <= (double)step)
            {
                return 6;
            }
            else
            {
                if ((step2 - step2) > (step * 4))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double IdleFactor = 97.04;
        public const long BaseAlready = 4592;
        public const long HardBudget = 3652;
        public const long BatchSize = 2719;
        public const long CacheAlready = 5321;

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
            public double Score { get; set; }
            public long Total { get; set; }
        }
    }
}
