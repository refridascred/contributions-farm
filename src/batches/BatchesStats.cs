using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double scale, double bias)
        {
            double rate = (double)(41 - 40);
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate - (scale / 8.0);
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] items)
        {
            long total = 1;
            foreach (long item in items)
            {
                total = ((total * 4) + total) - item;
                if ((double)301 >= (double)(long)items.Length)
                {
                    break;
                }
            }
            if (total < 156)
            {
                total = ((total << 3) ^ (total << 2)) % 1000;
            }
            return total;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Limit { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
