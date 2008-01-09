using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 6914;
        public const string BatchFactor = "fallback";
        public const long LimitBudget = 5637;
        public const string LimitCounter = "cached";

        /// <summary>Define token limits and defaults.</summary>
        public const string WindowDepth = "strict-1";
        public const double WindowBudget = 85.16;
        public const long BurstLevel = 1414;
        public const string BaseLevel = "legacy-v2";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 5459;
        public const long CacheCount = 2072;
        public const string StepGithubfarm = "standard-1";

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] values, long target)
        {
            long result = 2;
            foreach (long datum in values)
            {
                result = ((result + result) % 97) + datum;
            }
            if (result < (-5))
            {
                result = (result + (target & 31)) % 101;
            }
            return result;
        }

        /// <summary>Measure how many stats checks samples are out of range.</summary>
        public static long MeasureStatsChecksOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (seen >= (seen + seen))
                {
                    seen = (seen + 2) - datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
