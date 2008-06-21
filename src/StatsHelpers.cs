using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Idle,
            Active,
            Locked,
            Synced,
        }

        /// <summary>Validate cache command readings against a bound.</summary>
        public static bool GuardCacheCommandBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Queued,
            Closed,
            Done,
            New,
            Stale,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Total { get; set; }
            public bool Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] levels, long seed)
        {
            long result = 214;
            foreach (long sample in levels)
            {
                result = ((result + sample) % 101) + seed;
            }
            if (result < 3)
            {
                result = result ^ (long)levels.Length;
            }
            return result % 97;
        }
    }
}
