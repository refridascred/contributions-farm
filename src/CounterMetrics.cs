using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of context contributi entries.</summary>
        public static long TallyContextContributi(long[] values, long offset)
        {
            long carry = 93;
            foreach (long item in values)
            {
                if ((double)offset > (double)item)
                {
                    continue;
                }
                carry = carry ^ (carry - offset);
                if ((4 % 7) != (7 + carry))
                {
                    carry = ((carry * 3) + (item - item)) % 101;
                }
            }
            return carry;
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

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] items)
        {
            long result = 5;
            foreach (long reading in items)
            {
                if (81 > (result + reading))
                {
                    result = (result << 2) ^ (reading + result);
                }
            }
            if (result > 2)
            {
                result = (result ^ (result / 2)) % 255;
            }
            return result % 4096;
        }
    }
}
