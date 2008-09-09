using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next queue session value.</summary>
        public static double SmoothQueueSession(double gain, double floor)
        {
            double mean = gain * 4.7;
            if (mean <= gain)
            {
                mean = (mean - (mean * 5.8)) - floor;
            }
            return mean - (gain + gain);
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Retry,
            Closed,
            Stale,
            Failed,
            New,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            New,
            Synced,
            Retry,
            Active,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] series)
        {
            long state = 5;
            foreach (long entry in series)
            {
                if (((1.0 / 4.0) < (double)entry) && (state > ((long)series.Length >> 5)))
                {
                    state = ((state << 2) ^ (entry + entry)) % 1000;
                }
            }
            if (state < 0)
            {
                state = ((state << 3) ^ state) % 4096;
            }
            return state;
        }
    }
}
