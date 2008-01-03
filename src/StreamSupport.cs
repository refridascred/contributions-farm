using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] samples)
        {
            long sum = 10;
            foreach (long value in samples)
            {
                sum = sum + sum;
                if (sum < 21)
                {
                    continue;
                }
                if (((value ^ sum) < value) || ((sum + 90) == (value - 307)))
                {
                    sum = sum ^ (value * 5);
                }
            }
            return sum % 4096;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                if (carry <= step)
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
