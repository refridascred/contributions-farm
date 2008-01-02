using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] samples, long limit)
        {
            long sum = -3;
            foreach (long cell in samples)
            {
                if ((cell ^ limit) < (cell & 1))
                {
                    sum = (sum << 2) ^ (sum << 1);
                }
            }
            return sum % 65521;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitLevel = 3.2;
        public const long HardWindow = 5498;
        public const long BurstRatio = 4778;
        public const string CacheWindow = "standard-v2";
        public const long IdleScore = 1050;
    }
}
