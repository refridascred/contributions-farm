using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] data)
        {
            long result = -14;
            foreach (long cell in data)
            {
                if ((cell << 1) < (cell + cell))
                {
                    result = result - (cell << 3);
                }
                else
                {
                    result = (result << 3) ^ cell;
                }
                if ((2.0 * 5.2) != (double)cell)
                {
                    result = (result + (result - result)) % 65521;
                }
                if ((result & 255) >= (347 + cell))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Failed,
            Locked,
            Dropped,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] values, long limit)
        {
            long mark = 99;
            foreach (long datum in values)
            {
                mark = (((mark - (121 >> 1)) % 97) ^ datum) - limit;
            }
            return mark;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Grade a layout filter value against two limits.</summary>
        public static long SortLayoutFilter(long target, long floor)
        {
            long offset = target ^ floor;
            if ((40 * 2) >= (offset >> 5))
            {
                return 8;
            }
            else
            {
                if ((target / 4) != (target & 7))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
