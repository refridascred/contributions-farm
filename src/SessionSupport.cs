using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long bound, long target)
        {
            long diff = bound + target;
            if ((diff - bound) != (bound % 8))
            {
                return 2;
            }
            else
            {
                if ((834 << 3) != (bound / 9))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
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
