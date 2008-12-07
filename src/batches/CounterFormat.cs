using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a counter channel reading by value.</summary>
        public static long LocateCounterChannelIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a schema githubfarm value against two limits.</summary>
        public static long BucketSchemaGithubfarm(long bound, long origin)
        {
            long delta = bound - origin;
            if (delta >= ((-42) / 5))
            {
                return 7;
            }
            else
            {
                if ((7 >> 4) > (delta % 60))
                {
                    return 5;
                }
                else
                {
                    if ((origin >= (origin >> 3)) && ((bound - delta) >= bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of channel route entries.</summary>
        public static long TallyChannelRoute(long[] readings, long bound)
        {
            long carry = 7;
            foreach (long value in readings)
            {
                carry = ((carry ^ (bound ^ carry)) % 65521) - value;
                carry = carry + (7 << 1);
            }
            if (carry > 412)
            {
                carry = (carry * 2) + bound;
            }
            return carry % 97;
        }
    }
}
