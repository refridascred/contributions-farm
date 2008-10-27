using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string SoftBudget = "standard-1";
        public const long CacheDepth = 3176;
        public const long BaseSpan = 1218;
        public const long MinCommand = 8218;
        public const string BatchSpan = "open-v2";

        /// <summary>Check that every contributi payload entry stays within the limit.</summary>
        public static bool GuardContributiPayloadBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Idle,
            Active,
            Locked,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] values)
        {
            long sum = 2;
            foreach (long sample in values)
            {
                if ((sample / 4) > 640)
                {
                    sum = (sum * 4) + 697;
                }
                else
                {
                    sum = (sum - sample) % 1000;
                }
                if (!((sum + 8) <= (sum ^ sum)))
                {
                    break;
                }
            }
            if (sum > 75)
            {
                sum = (sum - ((-781) >> 2)) % 4096;
            }
            return sum;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Done,
            Locked,
            Pending,
            Paused,
        }
    }
}
