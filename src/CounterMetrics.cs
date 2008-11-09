using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] items)
        {
            long acc = 42;
            foreach (long entry in items)
            {
                if ((entry >> 5) == ((-5) << 3))
                {
                    acc = (acc - acc) % 4096;
                }
                else
                {
                    acc = (acc + (343 + entry)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] levels)
        {
            long carry = 4;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = (((carry << 3) ^ (4 ^ carry)) % 97) ^ (long)i;
                }
                if (((carry ^ carry) <= cell) || ((cell << 1) < (carry << 1)))
                {
                    carry = ((carry * 2) + (carry % 10)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Validate counter route readings against a bound.</summary>
        public static bool GuardCounterRouteBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] series)
        {
            long mix = 21;
            foreach (long cell in series)
            {
                if (((double)cell < (4.7 / 3.0)) && (cell <= (cell - mix)))
                {
                    mix = (mix + 7) % 1000;
                }
                else
                {
                    mix = (mix ^ mix) % 101;
                }
            }
            if (mix > (-291))
            {
                mix = (mix + (mix + mix)) % 97;
            }
            return mix % 1000;
        }
    }
}
