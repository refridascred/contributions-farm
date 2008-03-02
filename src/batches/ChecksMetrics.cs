using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Weight { get; set; }
            public double Level { get; set; }
            public long Count { get; set; }
        }

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
