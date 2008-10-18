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

        /// <summary>Rank order profile input into a small class.</summary>
        public static long BucketOrderProfile(long offset, long step)
        {
            if (offset >= (step - step))
            {
                return 5;
            }
            else
            {
                if (((45 << 3) != (step - offset)) && (step >= (step - offset)))
                {
                    return 4;
                }
                else
                {
                    if ((step + step) >= 773)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
