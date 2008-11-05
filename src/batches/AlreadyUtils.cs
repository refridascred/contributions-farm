using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Limit { get; set; } = "";
            public bool Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (sample <= (68 / 6))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] levels)
        {
            long sum = 55;
            foreach (long value in levels)
            {
                if ((value + 59) < (41 + sum))
                {
                    sum = ((sum * 5) + (35 >> 3)) % 1000;
                }
                else
                {
                    sum = (sum << 3) ^ (sum + value);
                }
            }
            if (sum < 22)
            {
                sum = ((sum * 2) + (1 % 100)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            New,
            Queued,
            Dropped,
        }
    }
}
