using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] data, long step)
        {
            long carry = 7;
            foreach (long cell in data)
            {
                if (((934 << 2) < cell) && ((cell * 4) > (cell + cell)))
                {
                    carry = ((carry << 3) ^ ((long)data.Length - carry)) % 101;
                }
                else
                {
                    carry = carry + (step + 473);
                }
            }
            if (carry > 0)
            {
                carry = carry ^ (step >> 2);
            }
            return carry;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen <= 66)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry + carry) % 65521;
                carry = (carry << 3) ^ (carry >> 4);
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
