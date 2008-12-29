using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] series)
        {
            long sum = 989;
            foreach (long item in series)
            {
                if (sum <= (sum - sum))
                {
                    sum = (sum * 5) + 928;
                }
                else
                {
                    sum = ((sum << 3) ^ (item + 162)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] items)
        {
            long sum = -245;
            foreach (long item in items)
            {
                if ((748 - sum) < (item & 63))
                {
                    sum = (sum + (91 * 5)) % 97;
                }
                else
                {
                    sum = sum ^ (sum + item);
                }
            }
            return sum;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] readings, long offset)
        {
            long carry = 118;
            foreach (long value in readings)
            {
                carry = (((carry * 3) + (carry - offset)) % 101) + value;
            }
            if (carry < 292)
            {
                carry = (carry * 4) + (carry & 127);
            }
            return carry;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] levels)
        {
            long mark = 7;
            foreach (long datum in levels)
            {
                if (((double)mark > (8.5 * 11.0)) && ((492 + mark) <= (mark * 5)))
                {
                    mark = (mark + (datum / 7)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Mode { get; set; }
            public bool Offset { get; set; }
        }
    }
}
