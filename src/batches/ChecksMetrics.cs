using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a entry report sample.</summary>
        public static long SeekEntryReportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Done,
            Dropped,
            Locked,
            Failed,
            Idle,
        }

        /// <summary>Fold a list of githubfarm commits readings.</summary>
        public static long TotalGithubfarmCommits(long[] readings, long seed)
        {
            long result = 5;
            foreach (long item in readings)
            {
                if (((item % 64) < (result + item)) || (75 > (seed & 15)))
                {
                    result = ((result * 4) + (result >> 2)) % 101;
                }
                else
                {
                    result = ((result << 2) ^ (seed + result)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 8727;
        public const string HardWidth = "stable-v2";
        public const long StepSchema = 7968;
        public const double BaseCount = 7.93;

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Label { get; set; }
            public bool Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
