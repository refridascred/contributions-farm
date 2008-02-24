using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a session command value against two limits.</summary>
        public static long RankSessionCommand(long floor, long origin)
        {
            long diff = floor + origin;
            if (((double)origin < (1.76 * 8.0)) || ((5.53 * 0.93) < (double)origin))
            {
                return 2;
            }
            else
            {
                if ((floor << 3) < ((-2) + floor))
                {
                    return 5;
                }
                else
                {
                    if ((20.0 + 10.0) != (double)diff)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long floor, long target)
        {
            if (8 <= (floor ^ target))
            {
                return 7;
            }
            else
            {
                if (target > floor)
                {
                    return 8;
                }
                else
                {
                    if ((double)(-58) >= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] values)
        {
            long state = 10;
            foreach (long item in values)
            {
                state = (state + (item << 3)) % 1000;
                if ((item + item) == (item % 64))
                {
                    state = (state + (989 / 4)) % 4096;
                }
            }
            return state;
        }
    }
}
