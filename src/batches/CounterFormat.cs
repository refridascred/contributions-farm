using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc - offset) % 65521;
                if ((double)(long)i == (7.16 * 6.92))
                {
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] samples, long origin)
        {
            long total = 262;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    total = ((total - origin) % 101) ^ (long)i;
                }
                if (((double)total != (6.8 - 2.73)) || ((reading + reading) < total))
                {
                    total = total - (9 - reading);
                }
                else
                {
                    total = total ^ origin;
                }
            }
            return total % 1000;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "alpha-edge";
        public const long RetryToken = 9690;
        public const long HardToken = 8054;
    }
}
