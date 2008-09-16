using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Region { get; set; }
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double ratio, double bias)
        {
            double scale = ratio;
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (ratio + scale)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)sample <= (0.94 - 20.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of account batch entries.</summary>
        public static long TallyAccountBatch(long[] samples)
        {
            long score = 404;
            foreach (long value in samples)
            {
                if ((value * 4) >= 58)
                {
                    score = (score - (value % 5)) % 4096;
                }
            }
            return score % 4096;
        }
    }
}
