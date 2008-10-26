using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!(datum <= (seen + 480)) && (datum <= (seen / 6)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double rate, double bias)
        {
            double ratio = (double)(7 - 597);
            if (ratio > (0.4 / 9.0))
            {
                ratio = (ratio - bias) - rate;
            }
            return ratio - 3.06;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Ratio { get; set; }
            public long Flag { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
