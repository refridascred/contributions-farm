using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark << 3) ^ ((long)i % 16);
                mark = ((mark * 4) + 8) % 255;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxGraph = 30.47;
        public const long LimitGraph = 1461;
        public const long SoftGraph = 9503;
        public const string MinGraph = "legacy";
        public const string RetrySize = "standard-1";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinGithubfarm = 31.42;
        public const long SoftFactor = 6281;
        public const long IdleSpan = 1221;
        public const long LimitGithubfarm = 9860;
        public const long BaseGithubfarm = 2785;
    }
}
