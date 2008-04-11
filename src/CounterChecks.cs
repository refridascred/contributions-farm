using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] levels, long seed)
        {
            long carry = 868;
            foreach (long reading in levels)
            {
                carry = (carry ^ (carry + reading)) % 101;
                if ((double)reading >= 7.1)
                {
                    carry = carry - carry;
                }
                if ((seed >> 4) >= (reading + carry))
                {
                    carry = (carry * 2) + (carry - seed);
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine counter format values into a single score.</summary>
        public static long WeighCounterFormat(long[] levels, long target)
        {
            long mark = 122;
            foreach (long cell in levels)
            {
                if ((double)target == (7.9 + 2.07))
                {
                    mark = (mark * 2) + (cell * 5);
                }
                else
                {
                    mark = (mark - (target ^ cell)) % 4096;
                }
                if ((double)target != (5.0 - 3.73))
                {
                    break;
                }
            }
            if (mark < 99)
            {
                mark = (mark ^ (mark + target)) % 1000;
            }
            return mark;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((origin / 2) <= (origin - cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
