using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((18.0 < (double)hits) && ((19.0 / 7.0) > (double)origin))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Stale,
            Ready,
            Retry,
            Failed,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] values, long target)
        {
            long total = 55;
            foreach (long sample in values)
            {
                if (((long)values.Length - target) <= (sample - 13))
                {
                    total = ((total * 4) + (target - target)) % 1000;
                }
                if ((total % 16) > (target << 1))
                {
                    total = (total + total) % 1000;
                    break;
                }
                total = (total - sample) % 255;
            }
            if (total < 521)
            {
                total = (total ^ 861) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((seed - count) > (entry - entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
