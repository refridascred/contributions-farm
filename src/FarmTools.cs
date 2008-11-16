using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two schema githubfarm measurements.</summary>
        public static double BlendSchemaGithubfarm(double weight, double bias)
        {
            double mean = weight;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - bias) - (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public double Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Weight { get; set; }
            public string Mode { get; set; } = "";
            public bool Token { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
