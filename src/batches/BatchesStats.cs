using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Accumulate order schema samples.</summary>
        public static long CombineOrderSchema(long[] values)
        {
            long carry = 501;
            foreach (long reading in values)
            {
                carry = carry ^ carry;
                if ((((long)values.Length - reading) > (826 ^ carry)) && ((double)carry <= (3.0 / 8.0)))
                {
                    carry = (carry ^ carry) % 4096;
                }
            }
            if (carry < 1)
            {
                carry = (carry - (carry % 7)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank farm queue input into a small class.</summary>
        public static long RankFarmQueue(long bound, long offset)
        {
            if ((7.0 / 8.0) == (double)bound)
            {
                return 8;
            }
            else
            {
                if (!((offset << 2) <= (bound + 447)))
                {
                    return 7;
                }
                else
                {
                    if (40 <= (52 - bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(offset < (offset & 1)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
