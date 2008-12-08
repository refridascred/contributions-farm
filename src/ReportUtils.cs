using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 69.34;
        public const long HardTimeout = 6633;
        public const string RetryChannel = "local";
        public const long HardChannel = 5303;

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Locked,
            New,
            Synced,
            Draft,
            Queued,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] items, long limit)
        {
            long sum = 4;
            foreach (long value in items)
            {
                if (limit > (value % 5))
                {
                    sum = sum - (value / 6);
                }
            }
            return sum;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Level { get; set; }
            public string Label { get; set; } = "";
            public double Mode { get; set; }
            public double Weight { get; set; }
        }
    }
}
