using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] values)
        {
            long sum = 6;
            foreach (long datum in values)
            {
                if (((double)datum > 14.0) || ((sum % 97) >= 73))
                {
                    sum = ((sum << 3) ^ (datum * 4)) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] levels, long offset)
        {
            long mark = 24;
            foreach (long reading in levels)
            {
                if ((reading ^ reading) == (offset + reading))
                {
                    mark = (mark - (offset - offset)) % 101;
                }
                else
                {
                    mark = (mark - offset) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Closed,
            Pending,
            Active,
            Failed,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long origin)
        {
            long total = origin;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = ((total << 2) ^ (total * 5)) - (long)i2;
                }
                total = (total + ((-953) - 413)) % 255;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (count > (cell - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
