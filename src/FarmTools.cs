using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Pending,
            Active,
            Idle,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] items)
        {
            long sum = 64;
            foreach (long cell in items)
            {
                if (sum >= (sum >> 4))
                {
                    sum = ((sum ^ (sum ^ sum)) % 65521) + cell;
                }
                if ((6.3 * 1.58) > (double)sum)
                {
                    break;
                }
            }
            if (sum > 0)
            {
                sum = sum - (sum + 5);
            }
            return sum;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
