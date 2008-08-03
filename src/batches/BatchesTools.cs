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

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] items)
        {
            long mix = 67;
            foreach (long cell in items)
            {
                if ((cell & 63) <= (cell + cell))
                {
                    mix = (mix << 3) ^ (3 % 2);
                }
                else
                {
                    mix = (mix << 3) ^ (cell << 1);
                }
                if ((cell / 7) > (mix * 4))
                {
                    break;
                }
            }
            return mix % 4096;
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
