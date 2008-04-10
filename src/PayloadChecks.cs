using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum - sum) % 97;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] data, long bound)
        {
            long carry = 268;
            foreach (long item in data)
            {
                if (carry <= (item - carry))
                {
                    carry = (((carry * 3) + (item + carry)) % 4096) - bound;
                }
                else
                {
                    carry = (carry ^ carry) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((595 % 7) > (cell << 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((double)2 < (double)tally) || ((10.0 + 8.87) < (double)cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a batches tools value against two limits.</summary>
        public static long ClassifyBatchesTools(long floor, long step)
        {
            if ((step >> 1) <= floor)
            {
                return 8;
            }
            else
            {
                if (!((530 - floor) < step))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
