using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double RetryReport = 84.67;
        public const long WindowSize = 7136;
        public const string RetryCount = "legacy-v2";
        public const double IdleReport = 79.01;
        public const string WindowReport = "local-1";

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 1059;
        public const long DefaultSpan = 6552;
        public const long RetryLevel = 6284;

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double ratio, double floor)
        {
            double scale = (double)((-5) + 73);
            if (scale <= (scale * 11.0))
            {
                scale = (scale + scale) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (8.87 + 11.0)) + (double)(long)i;
            }
            return scale + ratio;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public long Score { get; set; }
        }
    }
}
