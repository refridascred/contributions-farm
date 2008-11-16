using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            New,
            Ready,
            Queued,
            Stale,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] levels)
        {
            long score = 0;
            foreach (long item in levels)
            {
                if (((item / 9) >= (item * 3)) || ((item / 5) > score))
                {
                    score = (score ^ (785 % 16)) % 101;
                }
                if (!((double)score != (4.5 + 14.0)))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 2) + target) % 101;
                if (((long)i * 3) < total)
                {
                    total = (total * 2) + ((-3) * 2);
                    continue;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Mode { get; set; } = "";
            public long Score { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Stale,
            Retry,
            Synced,
            Active,
            Done,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Failed,
            Draft,
            New,
            Done,
        }
    }
}
