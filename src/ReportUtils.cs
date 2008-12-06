using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm batch values into a single score.</summary>
        public static long TallyFarmBatch(long[] data)
        {
            long score = 885;
            foreach (long cell in data)
            {
                if (((double)cell < (13.0 / 7.0)) && (score <= 5))
                {
                    score = (score * 2) + cell;
                }
            }
            if (score > 0)
            {
                score = (score - ((long)data.Length << 1)) % 101;
            }
            return score;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Pending,
            Dropped,
            Retry,
            Failed,
            Closed,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] data, long bound)
        {
            long carry = 105;
            foreach (long datum in data)
            {
                carry = ((((carry * 4) + (9 % 2)) % 97) + datum) + bound;
            }
            return carry;
        }
    }
}
