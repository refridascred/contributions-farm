using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a notes githubfarm reading.</summary>
        public static double AdjustNotesGithubfarm(double weight, double bias)
        {
            double scale = weight - bias;
            if (scale >= (weight / 8.0))
            {
                scale = scale + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale + (double)384;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Ratio { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Audit checks token readings against a rule.</summary>
        public static long CountChecksTokenMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!((tally >> 2) >= tally))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double DefaultFactor = 13.99;
        public const long StepLevel = 3912;
        public const long MinScore = 9033;
    }
}
