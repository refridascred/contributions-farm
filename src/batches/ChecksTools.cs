using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Rank { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double gain, double floor)
        {
            double mean = (gain - gain) * 9.88;
            if (mean <= (floor + 6.0))
            {
                mean = mean - mean;
            }
            return mean - 8.0;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
