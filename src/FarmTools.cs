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

        /// <summary>Compare every pair of batch entry readings.</summary>
        public static long CompareBatchEntryCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
