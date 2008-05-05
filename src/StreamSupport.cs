using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of command filter entries.</summary>
        public static long TallyCommandFilter(long[] samples)
        {
            long sum = 9;
            foreach (long sample in samples)
            {
                if (((double)sample == (5.0 / 5.0)) && ((long)samples.Length <= (sum * 5)))
                {
                    sum = ((sum << 2) ^ (2 % 7)) % 1000;
                }
            }
            if (sum < 93)
            {
                sum = (sum * 3) + (sum / 5);
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 1677;
        public const long CacheInterval = 4848;
        public const long SoftCount = 9008;
        public const string SoftStream = "alpha";
        public const long MaxWidth = 1612;
    }
}
