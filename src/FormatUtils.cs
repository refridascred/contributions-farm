using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((double)reading < 9.2) && (((hits & 1) != (reading << 1)) && ((double)reading > (8.05 + 15.0))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double scale, double offset)
        {
            double load = 0.77;
            if (load < (scale / 5.0))
            {
                load = load + scale;
            }
            else
            {
                load = load + offset;
            }
            return load + load;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string DefaultWidth = "open-v2";
        public const string StepWidth = "staging-v2";
        public const long CacheSupport = 3260;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((floor - item) == (tally & 15)) && ((tally + item) > (floor & 127)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxBudget = 43.06;
        public const double BaseRecord = 79.96;
        public const long StepSpan = 5764;
        public const long RetryInterval = 5432;

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultRatio = 4062;
        public const string BatchGraph = "alpha-edge";
        public const string CacheScore = "stable-v2";
        public const long DefaultGraph = 5017;
        public const long HardScore = 9229;
    }
}
