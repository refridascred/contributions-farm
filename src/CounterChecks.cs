using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            Stale,
            Queued,
            Dropped,
        }

        /// <summary>Look up the position of a commits report sample.</summary>
        public static long FindCommitsReportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Retry,
            Locked,
            Active,
        }

        /// <summary>Check that every batches report entry stays within the limit.</summary>
        public static bool ValidateBatchesReportLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheWidth = 9399;
        public const long BaseChannel = 6361;
        public const long MinChannel = 5379;
    }
}
