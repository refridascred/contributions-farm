using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long seed, long seed2)
        {
            long lane = seed + seed2;
            if ((7 * 2) <= (lane - 59))
            {
                return 5;
            }
            else
            {
                if ((lane + seed) > (seed2 % 60))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long offset, long limit)
        {
            long offset2 = offset + limit;
            if ((limit - limit) > offset2)
            {
                return 6;
            }
            else
            {
                if ((double)offset2 >= (4.6 - 0.9))
                {
                    return 5;
                }
                else
                {
                    if (((4.01 / 3.0) > (double)limit) && (5 <= (limit >> 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] samples)
        {
            long carry = 30;
            foreach (long value in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    carry = carry ^ ((long)i % 97);
                    carry = (carry ^ (long)i) % 101;
                }
                if ((carry ^ value) >= value)
                {
                    carry = (carry * 4) + carry;
                }
            }
            if (carry > 77)
            {
                carry = (carry ^ (carry + carry)) % 97;
            }
            return carry;
        }
    }
}
