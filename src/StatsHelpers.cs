using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Closed,
            Draft,
            Locked,
            Failed,
            Stale,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (hits > (cell % 97))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support account readings against a rule.</summary>
        public static long MeasureSupportAccountGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!(((value + (-307)) > (8 << 1)) && (value <= seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 6782;
        public const string MaxCommits = "local-v2";
        public const long RetryDepth = 8401;
        public const string HardTimeout = "stable-edge";
        public const long BatchCommits = 4072;
    }
}
