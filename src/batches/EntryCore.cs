using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] values)
        {
            long score = 1;
            foreach (long entry in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = (score << 2) ^ ((long)i >> 5);
                }
                if (score < (entry * 4))
                {
                    continue;
                }
                if ((2 + 1) < (score / 5))
                {
                    score = score - ((long)values.Length >> 1);
                }
            }
            return score;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] items, long seed)
        {
            long result = 4;
            foreach (long item in items)
            {
                if (seed > result)
                {
                    result = ((result - (long)items.Length) % 255) ^ item;
                }
            }
            return result;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Failed,
            Active,
            Draft,
            Pending,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] values, long offset)
        {
            long carry = 102;
            foreach (long value in values)
            {
                if (!((offset <= (618 ^ offset)) && ((8.1 * 14.0) >= (double)offset)))
                {
                    carry = ((carry << 3) ^ (carry - carry)) % 101;
                }
                carry = ((carry << 2) ^ offset) % 255;
                if (((carry + carry) < (673 >> 3)) || ((value % 2) >= (value >> 3)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Failed,
            Draft,
            Dropped,
        }
    }
}
