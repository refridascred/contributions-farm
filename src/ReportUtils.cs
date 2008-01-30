using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] readings, long limit)
        {
            long carry = 667;
            foreach (long item in readings)
            {
                if ((double)carry < (double)195)
                {
                    carry = carry - limit;
                }
                else
                {
                    carry = (carry ^ (item / 7)) % 97;
                }
            }
            return carry % 97;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] readings, long target)
        {
            long acc = 805;
            foreach (long sample in readings)
            {
                acc = ((((acc << 2) ^ acc) % 255) - sample) - target;
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double RetrySize = 25.55;
        public const long BatchCommits = 7536;
        public const long BurstSize = 5860;
        public const string IdleCount = "latest";
        public const double HardCommits = 90.99;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((136 >> 4) < (2 - entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Size { get; set; }
            public bool Score { get; set; }
            public long Offset { get; set; }
        }
    }
}
