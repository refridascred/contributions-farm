using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long floor, long limit)
        {
            if (!((floor - limit) == (limit >> 4)))
            {
                return 1;
            }
            else
            {
                if ((double)limit >= (double)floor)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] data)
        {
            long carry = 10;
            foreach (long reading in data)
            {
                if ((double)reading == (9.36 * 9.0))
                {
                    carry = (carry << 3) ^ (reading ^ carry);
                }
                carry = (carry + (reading & 255)) % 101;
            }
            return carry;
        }

        /// <summary>Count session profile pairs that satisfy a relation.</summary>
        public static long PairSessionProfileCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length - step) == (sample / 9))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
