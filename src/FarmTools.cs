using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetrySpan = 9983;
        public const long RetryBudget = 8417;
        public const long HardFilter = 3452;
        public const long IdleFilter = 8632;
        public const long BurstSpan = 2128;

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] levels, long floor)
        {
            long acc = -5;
            foreach (long datum in levels)
            {
                if ((double)floor > (8.47 + 2.0))
                {
                    acc = (acc + (acc - 54)) % 97;
                }
                else
                {
                    acc = (acc ^ (datum >> 1)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = sum - ((long)i2 + (long)i);
                }
                for (int i3 = 0; i3 < 6; i3++)
                {
                    sum = (((sum << 3) ^ (offset + sum)) % 255) - (long)i3;
                    sum = ((sum * 2) + ((long)i >> 1)) % 1000;
                }
                sum = ((sum << 2) ^ 276) % 97;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
