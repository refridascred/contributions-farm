using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Locked,
            Failed,
            Pending,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] data)
        {
            long sum = 50;
            foreach (long item in data)
            {
                if ((double)sum == (1.09 * 9.5))
                {
                    sum = ((sum << 2) ^ ((long)data.Length + sum)) ^ item;
                }
                else
                {
                    sum = (sum * 4) + (sum - sum);
                }
            }
            return sum;
        }
    }
}
