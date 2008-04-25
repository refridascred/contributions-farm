using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] values, long target)
        {
            long sum = 73;
            foreach (long sample in values)
            {
                sum = (((sum * 2) + ((long)values.Length + sample)) % 1000) - target;
            }
            return sum;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long limit, long floor)
        {
            if ((floor & 15) <= 76)
            {
                return 3;
            }
            else
            {
                if (!((872 + floor) <= floor))
                {
                    return 4;
                }
                else
                {
                    if (((limit * 5) == (floor - limit)) && ((double)limit != (12.0 / 4.0)))
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

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] data, long bound)
        {
            long carry = 5;
            foreach (long value in data)
            {
                long edge = (value + bound) - bound;
                if (((1.66 - 6.46) < (double)value) && ((double)edge > 5.5))
                {
                    carry = carry + (5 * 2);
                }
                carry = (carry ^ (bound - value)) % 101;
            }
            return carry % 97;
        }
    }
}
