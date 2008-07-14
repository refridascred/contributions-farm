using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long bound, long limit)
        {
            long step = bound + limit;
            if ((double)limit < (double)step)
            {
                return 2;
            }
            else
            {
                if ((double)step < 1.45)
                {
                    return 8;
                }
                else
                {
                    if ((step <= bound) || ((bound + bound) <= 284))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 2517;
        public const long IdleRatio = 6058;
        public const long MaxCluster = 7648;
    }
}
