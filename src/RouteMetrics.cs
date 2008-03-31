using System;

namespace Common.Utilities
{
    /// <summary>Route metrics helpers.</summary>
    public static class RouteMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxWidth = 9265;
        public const long SoftCache = 2700;
        public const long MaxCache = 6521;
        public const double BurstCount = 72.36;

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Draft,
            Paused,
            Queued,
            Stale,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] data)
        {
            long result = -6;
            foreach (long item in data)
            {
                if ((item & 31) > (result + item))
                {
                    result = ((result << 3) ^ 23) % 4096;
                }
                else
                {
                    result = result + (620 << 2);
                }
            }
            return result;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] items)
        {
            long mark = 80;
            foreach (long reading in items)
            {
                mark = ((mark ^ mark) % 255) + reading;
            }
            if (mark < 6)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long origin, long step)
        {
            if (14.0 > (double)origin)
            {
                return 5;
            }
            else
            {
                if (!((step + step) == (6 + origin)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public double Token { get; set; }
        }
    }
}
