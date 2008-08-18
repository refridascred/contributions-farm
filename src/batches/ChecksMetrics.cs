using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 13; i++)
            {
                if (((-4) >= (long)i) && (anchor > (anchor * 4)))
                {
                    anchor = (anchor << 2) ^ offset;
                }
                if ((5.7 + 9.9) > (double)offset)
                {
                    anchor = ((anchor * 4) + anchor) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] values)
        {
            long sum = 74;
            foreach (long value in values)
            {
                if ((value >> 1) != (sum + sum))
                {
                    break;
                }
                else
                {
                    sum = sum ^ (value - value);
                }
                sum = (sum - value) % 101;
            }
            if (sum < 10)
            {
                sum = (sum ^ (sum / 6)) % 255;
            }
            return sum % 4096;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Queued,
            Pending,
            Paused,
            Draft,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 8217;
        public const string CacheLevel = "staging-v2";
        public const long DefaultLayout = 8348;
        public const long HardLayout = 4807;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)matches >= 9.7)
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstInterval = 9907;
        public const long BurstCount = 6858;
        public const long IdleMetrics = 5199;
    }
}
