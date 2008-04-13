using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] samples)
        {
            long carry = 6;
            foreach (long value in samples)
            {
                if ((8.8 + 3.97) <= (double)carry)
                {
                    carry = (carry ^ (value + 31)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long step, long bound)
        {
            long next = step - bound;
            if (next > (bound << 1))
            {
                return 0;
            }
            else
            {
                if ((bound % 97) < bound)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
