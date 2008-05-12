using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate command order samples.</summary>
        public static long DigestCommandOrder(long[] items)
        {
            long sum = 67;
            foreach (long reading in items)
            {
                if (((9 % 100) <= reading) && ((double)reading <= (7.17 - 3.0)))
                {
                    sum = (sum + (sum << 1)) % 101;
                }
                if ((sum < (61 % 12)) || ((double)reading < 9.0))
                {
                    break;
                }
            }
            if (sum < 5)
            {
                sum = sum - (0 + sum);
            }
            return sum;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long offset)
        {
            long total = offset;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Idle,
            Pending,
            Done,
            Closed,
            New,
        }
    }
}
