using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Rank { get; set; } = "";
            public double Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 <= (gain + gain2))
            {
                gain2 = (gain2 + (double)829) + offset;
            }
            return gain2 - gain;
        }

        /// <summary>Fold a list of window profile readings.</summary>
        public static long ScoreWindowProfile(long[] samples, long offset)
        {
            long score = -881;
            foreach (long datum in samples)
            {
                if ((double)offset > (double)score)
                {
                    score = (score - offset) - datum;
                }
            }
            return score % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftSpan = "stable-1";
        public const double HardFactor = 75.44;
        public const long BatchFactor = 8231;
        public const long WindowBatches = 8615;
        public const string DefaultBudget = "local";

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Pending,
            Idle,
            Closed,
        }
    }
}
