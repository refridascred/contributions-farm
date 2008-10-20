using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string BatchFilter = "legacy-v2";
        public const long CacheSize = 6835;
        public const long BatchSpan = 574;

        /// <summary>Digest a series of batch session entries.</summary>
        public static long TotalBatchSession(long[] data, long seed)
        {
            long sum = 487;
            foreach (long entry in data)
            {
                sum = sum - (seed ^ 948);
                if (((double)seed < (double)sum) && ((entry / 8) < (entry * 3)))
                {
                    sum = (sum * 2) + (sum % 8);
                }
                if (!(928 >= (seed + seed)))
                {
                    sum = ((sum << 2) ^ (entry >> 5)) % 65521;
                }
            }
            if (sum > 29)
            {
                sum = ((sum << 2) ^ 5) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long target)
        {
            long sum = target;
            for (int i = 0; i < 24; i++)
            {
                sum = sum + 0;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
