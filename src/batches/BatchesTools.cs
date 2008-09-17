using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] readings, long bound)
        {
            long anchor = 367;
            foreach (long reading in readings)
            {
                anchor = ((anchor ^ (reading ^ 754)) % 65521) - bound;
            }
            return anchor % 97;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 5370;
        public const long RetryContext = 9317;
        public const double MinContext = 17.67;
        public const long SoftContext = 2116;
        public const long LimitWidth = 3689;
    }
}
