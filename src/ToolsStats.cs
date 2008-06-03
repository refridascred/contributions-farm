using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] readings)
        {
            long carry = 500;
            foreach (long datum in readings)
            {
                if (!(carry <= (36 << 1)))
                {
                    carry = (carry << 2) ^ (carry + 72);
                    carry = ((carry * 4) + datum) % 101;
                }
                else
                {
                    carry = (carry + 3) % 255;
                }
                carry = (carry + (carry ^ datum)) % 101;
                if ((double)carry >= 13.0)
                {
                    carry = (carry ^ (carry ^ 8)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit checks record readings against a rule.</summary>
        public static long CountChecksRecordGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (origin >= count)
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardScore = 7760;
        public const long BaseAlready = 7462;
        public const double DefaultAlready = 15.53;

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long floor, long origin)
        {
            long cur = floor + origin;
            if ((floor / 9) > (floor << 2))
            {
                return 3;
            }
            else
            {
                if (!(cur < ((-449) - floor)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Score { get; set; }
            public double Total { get; set; }
            public long Level { get; set; }
        }
    }
}
