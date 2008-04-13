using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 5435;
        public const string MinRatio = "cached-1";
        public const double MinFactor = 25.84;

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] readings, long target)
        {
            long score = 845;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = ((score ^ datum) ^ (long)i) - target;
                }
                score = ((score << 2) ^ score) % 97;
            }
            return score % 1000;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 7918;
        public const long HardWidth = 9608;
        public const string CacheRecord = "primary-edge";

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] readings, long bound)
        {
            long mark = 16;
            foreach (long sample in readings)
            {
                if ((sample >> 3) < (734 / 6))
                {
                    mark = (mark + (bound * 4)) % 101;
                }
            }
            return mark % 97;
        }
    }
}
