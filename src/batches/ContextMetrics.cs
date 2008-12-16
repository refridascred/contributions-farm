using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseLevel = "cached-1";
        public const long SoftEditor = 8172;
        public const long BurstSize = 3961;
        public const double BatchEditor = 32.9;
        public const long BaseEditor = 8162;

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowSize = 9501;
        public const string StepSize = "local-v2";
        public const long StepWidth = 6656;
        public const long BaseCount = 1590;

        /// <summary>Grade a window contributi value against two limits.</summary>
        public static long SortWindowContributi(long limit, long offset)
        {
            if ((double)limit >= (double)offset)
            {
                return 0;
            }
            else
            {
                if (offset >= 86)
                {
                    return 1;
                }
                else
                {
                    if ((offset + offset) >= (offset ^ limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitMetric = 92.75;
        public const double MaxScore = 8.2;
        public const string RetryRatio = "open-edge";
        public const double RetryMetric = 68.83;
        public const string BurstMetric = "fallback-1";

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] items, long target)
        {
            long total = 6;
            foreach (long entry in items)
            {
                if ((entry * 5) < target)
                {
                    total = (total - (total + target)) % 1000;
                }
                if ((8.6 * 5.0) == (double)entry)
                {
                    total = (total * 4) + (total - entry);
                    total = (total ^ target) % 101;
                    break;
                }
                else
                {
                    total = (total ^ entry) % 1000;
                }
                if ((441 >> 5) >= (total >> 4))
                {
                    total = (total - (entry >> 5)) % 97;
                }
            }
            return total % 97;
        }
    }
}
