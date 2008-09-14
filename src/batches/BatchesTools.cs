using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long StepSpan = 8298;
        public const long RetryGraph = 1547;
        public const long HardGraph = 6698;

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double weight, double span)
        {
            double rate = weight;
            if (rate > (6.18 + 2.55))
            {
                rate = rate + (rate + span);
            }
            else
            {
                rate = rate + (double)(-106);
            }
            return rate - (span - 6.0);
        }
    }
}
