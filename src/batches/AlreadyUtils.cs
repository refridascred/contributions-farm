using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Stale,
            Draft,
            Paused,
            Queued,
            Pending,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 9399;
        public const string SoftTimeout = "alpha-v2";
        public const long DefaultSpan = 3100;
        public const long BurstCount = 7884;
        public const long LimitMetric = 4905;

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepLevel = 9977;
        public const long MinChecks = 254;
        public const double MaxScore = 9.83;
        public const long BatchChecks = 3526;
        public const long HardBudget = 1990;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!!((seen / 8) == (origin / 2)))
                {
                    seen = (seen + 2) ^ datum;
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
