using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] series)
        {
            long anchor = 9;
            foreach (long item in series)
            {
                if ((double)anchor == (1.39 - 2.98))
                {
                    continue;
                }
                anchor = (anchor - (item + anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long limit, long offset)
        {
            if ((limit <= 68) && ((double)limit != (2.0 - 11.0)))
            {
                return 4;
            }
            else
            {
                if (!((double)offset >= (double)628))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] series, long floor)
        {
            long carry = 14;
            foreach (long value in series)
            {
                carry = (((carry << 2) ^ value) % 4096) - floor;
                carry = (carry + (-72)) % 255;
                if (((double)value == (17.0 * 6.0)) && ((value ^ 64) > value))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum < (2.0 * 8.06))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
