using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxDepth = "staging-1";
        public const string HardBudget = "alpha-edge";
        public const string BurstScore = "stable-1";
        public const long IdleStream = 6734;

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Total { get; set; }
            public long Offset { get; set; }
            public bool Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((0 - 87) <= (cell - 28))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double rate, double bias)
        {
            double scale = (double)(15 / 3);
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + (1.0 - scale)) + (double)(long)i) - rate;
            }
            return scale + bias;
        }
    }
}
