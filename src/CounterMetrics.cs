using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheTimeout = 9235;
        public const long BatchEntry = 6481;
        public const double CacheEntry = 18.44;
        public const string WindowInterval = "standard-v2";
        public const long BatchLevel = 2557;

        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstScore = "legacy-edge";
        public const long BaseCount = 2007;
        public const long HardQueue = 8562;
        public const double WindowScore = 28.18;

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every filter layout entry stays within the limit.</summary>
        public static bool VerifyFilterLayoutRange(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
