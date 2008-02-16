using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Weight { get; set; }
            public bool Token { get; set; }
            public string Size { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Stale,
            Failed,
            Queued,
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double rate, double floor)
        {
            double mean = rate;
            if (mean >= 5.0)
            {
                mean = mean + (mean / 8.0);
            }
            else
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + 3.04) + (double)(long)i;
            }
            return mean - 5.05;
        }
    }
}
