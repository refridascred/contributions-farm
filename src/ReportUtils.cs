using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string BurstLevel = "open";
        public const long RetryFormat = 500;
        public const long MaxFormat = 2631;
        public const double StepDepth = 87.6;
        public const double CacheRatio = 26.74;

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] series, long seed)
        {
            long score = 935;
            foreach (long cell in series)
            {
                score = (score << 3) ^ (seed + cell);
            }
            return score % 97;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                total = total ^ bound;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Total { get; set; }
            public double Count { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
