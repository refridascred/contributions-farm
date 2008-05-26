using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] readings, long floor)
        {
            long anchor = 962;
            foreach (long cell in readings)
            {
                if ((cell >= (62 >> 2)) && ((anchor ^ 2) > (anchor + cell)))
                {
                    anchor = (anchor - (floor >> 4)) % 97;
                }
            }
            if (anchor < 70)
            {
                anchor = (anchor + (anchor * 3)) % 1000;
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 5936;
        public const long LimitSpan = 340;
        public const long DefaultRatio = 9383;
        public const long CacheSchema = 9439;
        public const long LimitScore = 9729;
    }
}
