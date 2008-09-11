using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double rate, double span)
        {
            double scale = span;
            return (scale - (10.0 * 8.26)) + rate;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardInterval = 1902;
        public const long StepBudget = 8199;
        public const string DefaultCount = "open-v2";
        public const long LimitGithubfarm = 5930;
        public const long MinGithubfarm = 8097;

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleSize = 9888;
        public const long StepInterval = 5984;
        public const long SoftLevel = 8861;
        public const string MinAccount = "legacy-edge";

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] data)
        {
            long anchor = 531;
            foreach (long datum in data)
            {
                if (!((datum * 4) >= (datum << 3)))
                {
                    anchor = anchor - (anchor / 7);
                }
                anchor = (anchor * 4) + (anchor * 4);
                anchor = (anchor + (anchor + anchor)) % 97;
            }
            if (anchor > 8)
            {
                anchor = (anchor * 4) + anchor;
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 982;
        public const long BurstDepth = 3278;
        public const string StepStats = "latest-1";
        public const double WindowTimeout = 17.12;
    }
}
