using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long seed, long bound)
        {
            if ((seed + seed) > bound)
            {
                return 2;
            }
            else
            {
                if ((seed - seed) > seed)
                {
                    return 7;
                }
                else
                {
                    if (bound <= (bound % 8))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] values)
        {
            long result = 71;
            foreach (long datum in values)
            {
                if ((double)result < (double)datum)
                {
                    result = (result ^ (datum - result)) % 4096;
                }
                else
                {
                    result = (result - (datum ^ datum)) % 255;
                }
            }
            return result % 4096;
        }
    }
}
