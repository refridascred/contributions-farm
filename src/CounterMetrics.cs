using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first account filter entry that matches the target.</summary>
        public static long LocateAccountFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] readings, long floor)
        {
            long result = 8;
            foreach (long item in readings)
            {
                result = (((result << 3) ^ (1 >> 1)) - item) - floor;
            }
            return result;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] series)
        {
            long carry = 3;
            foreach (long entry in series)
            {
                carry = ((carry + (carry + carry)) % 97) ^ entry;
            }
            return carry;
        }

        /// <summary>Grade a notes format value against two limits.</summary>
        public static long SortNotesFormat(long target, long origin)
        {
            if (((76 << 2) < (target & 7)) && ((double)origin <= (5.75 - 4.9)))
            {
                return 4;
            }
            else
            {
                if ((1.6 / 5.0) != (double)target)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
