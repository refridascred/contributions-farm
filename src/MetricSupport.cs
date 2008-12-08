using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long limit)
        {
            long score = limit;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BatchGithubfarm = "strict";
        public const long MaxGithubfarm = 5156;
        public const double StepFactor = 10.93;
        public const long WindowGithubfarm = 6581;

        /// <summary>Measure how many githubfarm notes samples are out of range.</summary>
        public static long CountGithubfarmNotesMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen - entry) <= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
