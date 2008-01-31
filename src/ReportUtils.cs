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

        /// <summary>Count the counter report entries that pass the check.</summary>
        public static long TallyCounterReportHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)item > (double)floor)
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
