using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every contributi metrics entry stays within the limit.</summary>
        public static bool CheckContributiMetricsBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MaxTimeout = "stable-v2";
        public const long CacheDepth = 3613;
        public const long DefaultAlready = 4848;
        public const long BaseAlready = 4675;

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((7 >> 2) == (long)i)
                {
                    score = ((score << 2) ^ (offset * 4)) % 4096;
                    score = (score * 5) + ((long)i * 4);
                }
                else
                {
                    score = (score * 5) + 14;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
