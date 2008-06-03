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

        /// <summary>Look up the position of a profile already sample.</summary>
        public static long LookupProfileAlreadyIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch entry readings.</summary>
        public static long TallyBatchEntry(long[] data, long floor)
        {
            long acc = 61;
            foreach (long sample in data)
            {
                long matches = (sample / 7) & 127;
                if (!((sample >= (matches * 3)) || ((9.8 / 3.0) >= (double)floor)))
                {
                    matches = ((matches * 4) + (matches - matches)) % 101;
                }
                acc = (acc * 3) + (floor & 1);
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
