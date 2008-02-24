using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine farm stream values into a single score.</summary>
        public static long CombineFarmStream(long[] data)
        {
            long sum = 1;
            foreach (long reading in data)
            {
                if ((sum >> 5) >= (sum / 7))
                {
                    sum = sum + 6;
                }
                if ((reading + reading) != (reading * 5))
                {
                    sum = (sum + (reading + reading)) % 255;
                }
                else
                {
                    sum = sum ^ (4 - sum);
                }
            }
            if (sum > 8)
            {
                sum = (sum * 5) + 72;
            }
            return sum;
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
