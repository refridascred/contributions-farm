using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double weight, double offset)
        {
            double drift = weight;
            if (drift > (offset - 17.0))
            {
                drift = drift + weight;
            }
            else
            {
                drift = drift + (double)33;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (offset + weight)) + (double)(long)i;
            }
            return drift - (drift * 7.8);
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Score { get; set; }
            public double Label { get; set; }
        }
    }
}
