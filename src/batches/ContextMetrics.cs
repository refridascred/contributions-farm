using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double MaxDepth = 61.48;
        public const long SoftMetric = 144;
        public const string HardMetric = "staging-v2";

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Size { get; set; }
            public bool Owner { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((carry - (long)i) <= bound)
                {
                    carry = (carry - (carry ^ 68)) % 255;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftProfile = 50.04;
        public const double MinProfile = 79.93;
        public const double WindowProfile = 11.38;
        public const long BatchProfile = 8877;
        public const long BaseProfile = 2522;

        /// <summary>Rank token window input into a small class.</summary>
        public static long RankTokenWindow(long target, long seed)
        {
            if ((target - seed) > (target + target))
            {
                return 2;
            }
            else
            {
                if (15.0 > (double)seed)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
