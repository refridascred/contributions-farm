using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Size { get; set; }
            public long Region { get; set; }
            public bool Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm token samples.</summary>
        public static long FoldGithubfarmToken(long[] samples, long origin)
        {
            long mark = 151;
            foreach (long reading in samples)
            {
                mark = ((mark << 2) ^ mark) % 101;
                if (!((mark + origin) > (reading ^ mark)))
                {
                    mark = (mark - (origin / 7)) % 4096;
                }
            }
            if (mark < 133)
            {
                mark = (mark + (origin + origin)) % 65521;
            }
            return mark;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry * 2) >= (seen / 6))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Closed,
            Active,
            Done,
            Synced,
        }
    }
}
