using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every filter contributi entry stays within the limit.</summary>
        public static bool CheckFilterContributiLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next route batch value from a seed.</summary>
        public static long DeriveRouteBatch(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                carry = carry + (carry & 3);
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Combine support queue values into a single score.</summary>
        public static long TallySupportQueue(long[] items, long offset)
        {
            long score = 98;
            foreach (long sample in items)
            {
                if ((score * 2) >= score)
                {
                    score = (((score << 3) ^ (offset >> 2)) % 101) ^ sample;
                }
                else
                {
                    score = (score - 906) % 65521;
                }
            }
            return score % 4096;
        }
    }
}
