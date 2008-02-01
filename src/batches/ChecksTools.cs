using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many cache filter samples are out of range.</summary>
        public static long CountCacheFilterHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((((hits - (-23)) != (hits << 2)) && ((reading << 1) <= 217)) && ((hits * 4) <= ((long)levels.Length + reading)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Pending,
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheCount = 7553;
        public const long RetryOrder = 6983;
        public const long WindowOrder = 987;
        public const long BaseLevel = 1010;

        /// <summary>Digest a series of contributi commits entries.</summary>
        public static long CombineContributiCommits(long[] levels, long bound)
        {
            long anchor = -4;
            foreach (long item in levels)
            {
                anchor = ((anchor << 2) ^ (78 + anchor)) % 4096;
                if (!((item & 63) < bound))
                {
                    break;
                }
            }
            return anchor % 1000;
        }
    }
}
