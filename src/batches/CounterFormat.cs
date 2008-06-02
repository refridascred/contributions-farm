using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long origin, long limit)
        {
            if (((double)limit < (1.0 - 4.9)) && (origin > (origin % 97)))
            {
                return 6;
            }
            else
            {
                if ((double)limit > 7.0)
                {
                    return 0;
                }
                else
                {
                    if ((limit % 3) <= (limit + 8))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Look up the position of a payload already sample.</summary>
        public static long FindPayloadAlreadyIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
