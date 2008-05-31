using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultBudget = 3141;
        public const string DefaultSize = "alpha-v2";
        public const long RetryGithubfarm = 131;

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] levels, long target)
        {
            long mark = 589;
            foreach (long sample in levels)
            {
                mark = ((mark << 2) ^ sample) % 101;
                if ((mark < target) && ((816 + 9) <= (mark + mark)))
                {
                    mark = mark ^ (79 + 1);
                }
                mark = ((mark * 3) + (target + target)) % 255;
            }
            return mark;
        }

        /// <summary>Measure how many session profile samples are out of range.</summary>
        public static long AuditSessionProfileHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((9.0 * 7.54) >= (double)hits) || (((reading * 3) == (reading << 3)) || ((double)hits > 3.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            Done,
            Paused,
            Draft,
        }
    }
}
