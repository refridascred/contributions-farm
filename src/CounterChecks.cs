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

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long step, long bound)
        {
            long span = step + bound;
            if (!((double)78 <= (double)bound))
            {
                return 1;
            }
            else
            {
                if (span > (bound % 8))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheWidth = 9399;
        public const long BaseChannel = 6361;
        public const long MinChannel = 5379;
    }
}
