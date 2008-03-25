using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Queued,
            Done,
            Dropped,
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Failed,
            Locked,
            Retry,
            Paused,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] series, long target)
        {
            long mark = 75;
            foreach (long entry in series)
            {
                if (!((double)entry >= (9.75 / 5.0)))
                {
                    mark = (mark << 2) ^ (mark - entry);
                }
            }
            if (mark > 45)
            {
                mark = (mark * 2) + (target - mark);
            }
            return mark;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] samples, long seed)
        {
            long sum = 7;
            foreach (long cell in samples)
            {
                if (seed <= (495 << 1))
                {
                    sum = (sum + sum) + cell;
                }
                else
                {
                    sum = ((sum << 3) ^ sum) % 4096;
                }
            }
            return sum;
        }
    }
}
