using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((limit & 1) == (long)i)
                {
                    total = total + (limit - limit);
                }
                if ((total & 7) < (total - 44))
                {
                    total = ((total * 5) + ((long)i - (long)i)) % 255;
                }
                if (6.2 >= (double)(long)i)
                {
                    total = (total - ((long)i + total)) % 255;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] items, long target)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((count % 97) != (count + sample)) || ((target - target) <= ((-328) % 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((9.0 - 5.65) <= (double)floor)
                {
                    acc = (acc - (floor + (long)i)) % 255;
                    continue;
                }
                if (!(floor < (acc % 97)))
                {
                    acc = ((acc * 3) + (floor - acc)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
