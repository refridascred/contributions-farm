using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] levels, long offset)
        {
            long sum = 50;
            foreach (long sample in levels)
            {
                sum = ((sum << 3) ^ (sample - 4)) % 255;
                if (((sum << 1) <= (offset & 31)) || ((8.49 / 8.0) == (double)(long)levels.Length))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= seed)
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
            Queued,
            Ready,
        }
    }
}
