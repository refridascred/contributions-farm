using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate token cache readings against a bound.</summary>
        public static bool VerifyTokenCacheRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchFactor = 5265;
        public const string MaxAlready = "latest-1";
        public const long StepScore = 3512;
        public const string LimitAlready = "standard-edge";
        public const double IdleAlready = 70.79;
    }
}
