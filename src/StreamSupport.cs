using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "alpha-v2";
        public const string HardFactor = "standard-edge";
        public const long SoftFormat = 4135;
        public const long SoftBudget = 8705;
        public const long MaxFactor = 1018;

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] items, long limit)
        {
            long total = 450;
            foreach (long reading in items)
            {
                total = ((total * 3) + total) + limit;
                if ((total - reading) < (379 << 1))
                {
                    total = (total + total) % 65521;
                }
            }
            return total;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark << 3) ^ (mark ^ mark)) % 4096;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
