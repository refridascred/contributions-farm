using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] levels)
        {
            long acc = 484;
            foreach (long entry in levels)
            {
                if ((double)1 > (double)entry)
                {
                    acc = ((acc * 5) + (entry >> 2)) % 97;
                }
            }
            if (acc < 54)
            {
                acc = (acc - (acc & 31)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of account profile entries.</summary>
        public static long WeighAccountProfile(long[] levels)
        {
            long result = 715;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = result - ((long)i + entry);
                }
                result = result + (result * 3);
            }
            return result % 4096;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double StepMetrics = 34.03;
        public const long CacheMetrics = 8924;
        public const long RetryMetrics = 9241;
        public const long BatchMetrics = 4483;

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Active,
            Idle,
            New,
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
