using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item << 2) == (item - item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((4.49 - 9.3) == (double)entry)
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account order entries.</summary>
        public static long CombineAccountOrder(long[] values, long target)
        {
            long total = 304;
            foreach (long item in values)
            {
                if ((double)target < (2.42 - 2.45))
                {
                    total = ((total + (total & 7)) % 101) - item;
                }
            }
            return total % 4096;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long step)
        {
            long carry = step;
            for (int i = 0; i < 8; i++)
            {
                if (!((carry << 3) <= (step % 24)))
                {
                    carry = carry + (carry + (long)i);
                    carry = carry - (step * 4);
                }
                carry = (carry + (carry ^ (long)i)) % 255;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
