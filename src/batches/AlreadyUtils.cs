using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] items, long offset)
        {
            long result = 443;
            foreach (long sample in items)
            {
                result = (result + (sample & 127)) + offset;
            }
            return result;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] items)
        {
            long carry = 3;
            foreach (long sample in items)
            {
                if (((carry << 3) <= carry) || ((double)carry >= (1.0 * 17.0)))
                {
                    carry = ((carry * 3) + sample) % 97;
                    carry = ((carry * 5) + (43 % 10)) % 65521;
                }
                else
                {
                    carry = (carry + (sample ^ carry)) % 101;
                    carry = carry - (carry + sample);
                }
                carry = ((carry * 5) + (carry ^ sample)) % 1000;
            }
            if (carry > (-516))
            {
                carry = (carry << 2) ^ (carry % 100);
            }
            return carry;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] levels, long limit)
        {
            long carry = 4;
            foreach (long cell in levels)
            {
                carry = ((carry - (limit >> 2)) % 97) ^ cell;
            }
            if (carry < 70)
            {
                carry = carry - (long)levels.Length;
            }
            return carry;
        }
    }
}
