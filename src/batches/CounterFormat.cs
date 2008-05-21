using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long limit, long step)
        {
            if (!((4 + step) < (step + step)))
            {
                return 8;
            }
            else
            {
                if ((step / 4) < limit)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every batch already entry stays within the limit.</summary>
        public static bool CheckBatchAlreadyRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Pending,
            Paused,
            Ready,
        }
    }
}
