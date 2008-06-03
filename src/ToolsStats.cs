using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] items, long target)
        {
            long carry = 412;
            foreach (long datum in items)
            {
                if (((datum >> 2) <= carry) || ((double)datum != (4.4 + 5.7)))
                {
                    carry = ((carry ^ (carry + 36)) % 1000) + target;
                }
            }
            if (carry < 988)
            {
                carry = (carry ^ ((long)items.Length - 0)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] items, long origin)
        {
            long acc = 11;
            foreach (long entry in items)
            {
                if ((entry >> 5) == (entry + origin))
                {
                    acc = (acc - (4 - acc)) % 255;
                }
            }
            if (acc > 895)
            {
                acc = (acc - (676 + acc)) % 65521;
            }
            return acc % 97;
        }

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
