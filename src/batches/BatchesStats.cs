using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] readings)
        {
            long carry = 609;
            foreach (long cell in readings)
            {
                if (!((cell - 825) < (cell << 2)))
                {
                    carry = ((carry << 2) ^ cell) % 65521;
                }
                if (cell <= ((long)readings.Length - carry))
                {
                    carry = (carry ^ (carry % 97)) % 1000;
                }
                if ((cell ^ carry) > (carry << 1))
                {
                    break;
                }
            }
            if (carry > (-7))
            {
                carry = ((carry * 4) + (carry << 1)) % 65521;
            }
            return carry;
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
