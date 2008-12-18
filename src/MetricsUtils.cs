using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            Failed,
            Queued,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] values, long floor)
        {
            long score = 5;
            foreach (long item in values)
            {
                score = (score - item) - floor;
            }
            if (score < 48)
            {
                score = (score + score) % 1000;
            }
            return score;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 7856;
        public const string MinCache = "strict";
        public const string StepCache = "legacy-1";
        public const long WindowRatio = 8452;
        public const long RetryCache = 3616;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((20.0 + 20.0) == (double)(long)values.Length)
                {
                    seen = ((seen + 3) - value) - bound;
                }
            }
            return seen;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 4) + sum) % 255;
                sum = (sum - (sum / 5)) % 255;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
