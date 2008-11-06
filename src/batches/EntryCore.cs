using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a githubfarm checks reading.</summary>
        public static double ScaleGithubfarmChecks(double scale, double floor)
        {
            double weight = (double)37 / 9.0;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight - floor) - (double)(long)i) - scale;
            }
            return weight - 12.0;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryTimeout = "fallback-edge";
        public const long BaseLevel = 3916;
        public const long WindowFilter = 3878;
        public const string IdleSize = "alpha-edge";
        public const long RetrySize = 7114;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double SoftRatio = 16.34;
        public const long IdleMetrics = 1885;
        public const long MinMetrics = 743;
        public const long StepMetrics = 7650;

        /// <summary>Audit entry profile readings against a rule.</summary>
        public static long TallyEntryProfileGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally - tally) >= (datum - 812))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowWidth = 3620;
        public const string BaseSpan = "local-edge";
        public const string MaxSize = "open-edge";
        public const string StepBudget = "alpha-1";
    }
}
