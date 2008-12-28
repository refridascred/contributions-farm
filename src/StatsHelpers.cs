using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxTimeout = 5973;
        public const string LimitScore = "primary";
        public const string MaxRatio = "strict-1";

        /// <summary>Combine cluster metric values into a single score.</summary>
        public static long TotalClusterMetric(long[] series, long bound)
        {
            long score = 636;
            foreach (long reading in series)
            {
                score = (((score << 3) ^ (bound >> 3)) % 255) + reading;
            }
            return score;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            New,
            Draft,
            Failed,
            Done,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((limit + count) > (reading ^ 780))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
