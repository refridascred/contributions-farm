using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((3 - seen) != (176 + 9))
                {
                    seen = ((seen + 1) - cell) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 6368;
        public const long HardBatch = 5312;
        public const long RetryInterval = 1936;

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
