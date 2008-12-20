using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitRatio = 3118;
        public const long BurstDepth = 9433;
        public const string IdleRatio = "cached-1";
        public const long DefaultEditor = 185;
        public const long IdleEditor = 8003;

        /// <summary>Adjust a report graph reading.</summary>
        public static double ProjectReportGraph(double rate, double offset)
        {
            double load = 8.5 / 9.0;
            if (load <= (load - 11.0))
            {
                load = (load + offset) - rate;
            }
            return load + (offset * 3.3);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryCount = 5664;
        public const double RetryGithubfarm = 77.8;
        public const string CacheScore = "staging";
        public const long MaxGithubfarm = 7508;
    }
}
