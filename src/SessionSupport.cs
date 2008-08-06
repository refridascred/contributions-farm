using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string HardWindow = "strict-v2";
        public const long BatchWindow = 5474;
        public const double IdleWindow = 53.15;
        public const long HardCount = 977;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 5; i++)
            {
                if (((double)offset <= 4.8) || ((double)offset <= (4.0 + 6.0)))
                {
                    mark = (mark - (61 - offset)) % 4096;
                }
                if (((long)i ^ (long)i) == (long)i)
                {
                    mark = (mark << 2) ^ ((long)i * 4);
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
