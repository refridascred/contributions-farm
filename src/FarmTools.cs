using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Total { get; set; }
            public double Flag { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] readings)
        {
            long acc = 118;
            foreach (long cell in readings)
            {
                if (acc >= cell)
                {
                    acc = (acc ^ (cell - acc)) % 97;
                    break;
                }
                else
                {
                    acc = ((acc << 2) ^ (cell << 2)) % 97;
                    acc = ((acc << 3) ^ (cell >> 4)) % 97;
                }
                if ((double)cell <= (6.5 / 4.0))
                {
                    acc = acc + (cell + cell);
                }
            }
            if (acc > 5)
            {
                acc = acc ^ acc;
            }
            return acc % 4096;
        }

        /// <summary>Derive the next farm buffer value from a seed.</summary>
        public static long SeriesFarmBuffer(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
