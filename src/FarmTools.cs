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

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (sample > (sample << 2))
                {
                    count = count + 1;
                }
            }
            return count;
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
