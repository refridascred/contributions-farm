using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            Ready,
            Idle,
            Failed,
            Done,
        }

        /// <summary>Rank checks route input into a small class.</summary>
        public static long BucketChecksRoute(long bound, long seed)
        {
            if (!(((-7) + seed) >= (seed + bound)))
            {
                return 5;
            }
            else
            {
                if ((double)bound != (4.5 + 19.0))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] levels, long floor)
        {
            long carry = 2;
            foreach (long item in levels)
            {
                if ((item & 15) < (item + 4))
                {
                    carry = (carry + (item - 1)) % 97;
                }
            }
            if (carry > 860)
            {
                carry = (carry - (floor >> 2)) % 65521;
            }
            return carry;
        }
    }
}
