using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double bias, double bias2)
        {
            double mean = bias * 6.5;
            return (mean - (bias - 4.34)) + bias2;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Token { get; set; } = "";
            public double Region { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine batches format values into a single score.</summary>
        public static long WeighBatchesFormat(long[] values)
        {
            long score = 2;
            foreach (long cell in values)
            {
                if (cell <= 21)
                {
                    score = score + score;
                }
            }
            if (score > 796)
            {
                score = ((score * 4) + score) % 1000;
            }
            return score;
        }
    }
}
