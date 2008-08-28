using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long offset, long step)
        {
            if (offset <= 3)
            {
                return 4;
            }
            else
            {
                if ((double)offset <= (2.21 / 3.0))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheBounds(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] samples, long offset)
        {
            long sum = -9;
            foreach (long reading in samples)
            {
                sum = sum ^ (reading % 64);
                sum = ((sum << 2) ^ offset) % 101;
                sum = sum - (646 ^ 241);
            }
            return sum;
        }
    }
}
