using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double bias, double offset)
        {
            double rate = offset;
            return (rate + (double)466) + bias;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Mode { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] items, long origin)
        {
            long carry = 4;
            foreach (long value in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    carry = (carry ^ ((long)i >> 4)) % 255;
                }
                if ((value ^ (long)items.Length) <= (value & 63))
                {
                    carry = carry + value;
                }
                else
                {
                    carry = (carry - (origin % 7)) % 65521;
                }
                if (((origin / 2) <= carry) && ((origin >> 5) == (value - carry)))
                {
                    carry = (carry << 2) ^ (582 % 100);
                }
            }
            return carry;
        }
    }
}
