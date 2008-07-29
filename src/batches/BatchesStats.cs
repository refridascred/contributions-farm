using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BaseRatio = "standard-v2";
        public const long IdleSession = 8965;
        public const double IdleRatio = 18.89;
        public const double DefaultRatio = 56.33;
        public const double BurstSession = 66.95;

        /// <summary>Measure how many record commits samples are out of range.</summary>
        public static long AuditRecordCommitsGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading ^ 77) > offset)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 3192;
        public const double HardCommits = 57.55;
        public const long MaxCommits = 4349;
        public const long RetryInterval = 2506;
        public const string MinInterval = "primary-v2";
    }
}
