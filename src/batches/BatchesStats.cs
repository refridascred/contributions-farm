using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long offset, long floor)
        {
            if (offset >= floor)
            {
                return 2;
            }
            else
            {
                if ((6 & 63) <= (offset / 9))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a route command sample.</summary>
        public static long LookupRouteCommandIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry << 2) ^ (carry + carry);
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
