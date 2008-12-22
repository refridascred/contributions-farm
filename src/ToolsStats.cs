using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double gain, double span)
        {
            double rate = span + (span * 8.78);
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + span) + (double)(long)i) - gain;
            }
            return rate + (double)87;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Score { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item - 68) <= (count + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstLevel = 1555;
        public const long BatchCount = 9643;
        public const string CacheInterval = "fallback-v2";
        public const string BurstScore = "standard";

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 880;
        public const long WindowTimeout = 6431;
        public const long SoftRecord = 4160;
        public const long IdleInterval = 9753;
        public const long BurstRecord = 4014;

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
