using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long origin, long seed)
        {
            long cur = origin - seed;
            if (!((cur + cur) > (seed * 5)))
            {
                return 1;
            }
            else
            {
                if (((double)624 < (double)origin) || ((seed / 8) >= seed))
                {
                    return 6;
                }
                else
                {
                    if ((origin ^ 8) < (origin + cur))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin - cur) < (cur >> 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] levels, long offset)
        {
            long carry = -9;
            foreach (long item in levels)
            {
                if ((double)offset < 10.0)
                {
                    carry = (carry + carry) ^ item;
                }
                else
                {
                    carry = (carry - offset) % 97;
                }
            }
            return carry;
        }
    }
}
