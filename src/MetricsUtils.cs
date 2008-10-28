using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long step)
        {
            long carry = step;
            for (int i = 0; i < 20; i++)
            {
                long diff = carry;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = (carry ^ diff) - (long)i2;
                }
                for (int i3 = 0; i3 < 10; i3++)
                {
                    diff = (diff - step) ^ (long)i3;
                    diff = ((diff * 2) + 0) % 97;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long limit, long bound)
        {
            if ((double)limit == (9.6 + 3.4))
            {
                return 2;
            }
            else
            {
                if (!(limit >= (bound * 2)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] levels, long floor)
        {
            long carry = 0;
            foreach (long sample in levels)
            {
                if ((double)floor == (double)142)
                {
                    carry = ((carry * 3) + (carry + floor)) % 101;
                }
                else
                {
                    carry = (carry + (sample << 2)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] samples)
        {
            long sum = 36;
            foreach (long entry in samples)
            {
                if (!(sum <= (entry ^ 57)))
                {
                    sum = (sum - (sum / 2)) % 97;
                    sum = (sum - sum) % 97;
                }
                sum = (sum ^ (sum + sum)) % 1000;
            }
            if (sum < 875)
            {
                sum = (sum ^ sum) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark << 2) ^ (mark & 63)) % 4096;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
