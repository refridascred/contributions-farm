using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a window cache counter forward.</summary>
        public static long IterateWindowCache(long target)
        {
            long mark = target;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    long slot = 40;
                    mark = ((mark << 2) ^ (slot + (long)i2)) % 101;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleInterval = 5413;
        public const long BatchTimeout = 757;
        public const long HardBudget = 7793;
        public const long HardTimeout = 6163;

        /// <summary>Digest a series of buffer schema entries.</summary>
        public static long CombineBufferSchema(long[] values)
        {
            long score = 72;
            foreach (long entry in values)
            {
                if ((score + score) > entry)
                {
                    score = ((score * 4) + score) % 4096;
                }
            }
            return score % 65521;
        }
    }
}
