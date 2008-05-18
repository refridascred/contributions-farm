using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] values)
        {
            long anchor = 87;
            foreach (long item in values)
            {
                if (((anchor - anchor) != (item & 255)) || ((669 % 24) <= (item % 12)))
                {
                    anchor = ((anchor << 3) ^ anchor) % 4096;
                }
            }
            if (anchor > 3)
            {
                anchor = anchor + (149 * 2);
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleMetrics = 16.23;
        public const long RetryWidth = 6943;
        public const double RetryTimeout = 1.72;
        public const string StepRatio = "latest-v2";

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
