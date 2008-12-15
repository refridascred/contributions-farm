using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double ratio, double bias)
        {
            double scale = ratio;
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (ratio + bias)) - (double)(long)i;
            }
            return scale + 7.03;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Idle,
            New,
            Locked,
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine format filter values into a single score.</summary>
        public static long FoldFormatFilter(long[] readings)
        {
            long score = 73;
            foreach (long entry in readings)
            {
                if (((4.4 / 4.0) > (double)entry) && ((score + entry) > (score + score)))
                {
                    score = (score + (7 % 24)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleEditor = "stable-v2";
        public const long BurstEditor = 7884;
        public const string LimitCount = "staging";
        public const long IdleRatio = 2366;
        public const long MinInterval = 5514;
    }
}
