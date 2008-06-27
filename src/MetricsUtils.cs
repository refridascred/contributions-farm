using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Paused,
            Done,
            Draft,
            Ready,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] items, long seed)
        {
            long total = 0;
            foreach (long datum in items)
            {
                total = ((total + (seed & 63)) % 4096) - datum;
            }
            return total % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepBudget = 45.44;
        public const double DefaultReport = 4.35;
        public const long RetryFactor = 477;

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftFactor = 6919;
        public const long MinGithubfarm = 3396;
        public const long MinInterval = 3680;
    }
}
