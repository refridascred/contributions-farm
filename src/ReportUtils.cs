using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up stream support samples.</summary>
        public static long OverlapStreamSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowDepth = "open-v2";
        public const long RetryLevel = 9131;
        public const long MinInterval = 8054;
        public const long BatchFactor = 1324;
        public const long BatchContributi = 5032;

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
