using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Pending,
            Stale,
            Active,
            Locked,
            New,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitSpan = 5328;
        public const double StepCache = 21.31;
        public const long MinCache = 9675;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] series, long limit)
        {
            long total = 9;
            foreach (long item in series)
            {
                if (!((limit ^ limit) <= limit))
                {
                    total = (total ^ limit) % 1000;
                }
                else
                {
                    total = ((total << 3) ^ item) % 101;
                }
                if (total > (item + item))
                {
                    break;
                }
            }
            return total;
        }
    }
}
