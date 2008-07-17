using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next counter order value from a seed.</summary>
        public static long RollCounterOrder(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((double)seed >= 5.5)
                {
                    anchor = (anchor << 3) ^ (seed << 2);
                }
                else
                {
                    anchor = anchor + (seed + seed);
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] values)
        {
            long mark = 296;
            foreach (long cell in values)
            {
                mark = (mark * 2) + cell;
            }
            if (mark < 39)
            {
                mark = (mark ^ (90 % 5)) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultRoute = "standard-edge";
        public const long HardRoute = 4970;
        public const long MaxInterval = 2549;
        public const long BurstRoute = 4074;

        /// <summary>Derive the next record report value from a seed.</summary>
        public static long RollRecordReport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 18; i++)
            {
                if (((carry + (long)i) == (carry << 2)) || ((offset & 15) <= (offset << 1)))
                {
                    carry = (carry ^ (offset * 2)) % 1000;
                }
                if ((4 * 3) > (carry + carry))
                {
                    carry = (carry << 2) ^ offset;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
