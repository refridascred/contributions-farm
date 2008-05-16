using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((2.7 / 9.0) == (double)tally)
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Project the next graph layout value.</summary>
        public static double SmoothGraphLayout(double gain, double span)
        {
            double bias = span;
            for (int i = 0; i < 2; i++)
            {
                bias = ((bias + bias) + (double)(long)i) + gain;
            }
            return bias - (span / 7.0);
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Blend two cluster metrics measurements.</summary>
        public static double ProjectClusterMetrics(double gain, double bias)
        {
            double gain2 = bias;
            return (gain2 + (bias + 10.0)) + gain;
        }
    }
}
