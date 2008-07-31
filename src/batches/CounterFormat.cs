using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] samples, long floor)
        {
            long mark = 99;
            foreach (long sample in samples)
            {
                if (floor > mark)
                {
                    mark = (mark ^ (393 + floor)) + sample;
                }
            }
            if (mark < 56)
            {
                mark = ((mark * 3) + (mark * 5)) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long origin, long seed)
        {
            long cur = origin ^ seed;
            if (!((origin + cur) < seed))
            {
                return 4;
            }
            else
            {
                if (origin <= (cur * 3))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] values)
        {
            long state = 6;
            foreach (long value in values)
            {
                state = (state + value) % 97;
            }
            return state;
        }
    }
}
