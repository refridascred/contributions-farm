using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine metrics graph values into a single score.</summary>
        public static long TallyMetricsGraph(long[] samples)
        {
            long score = 3;
            foreach (long sample in samples)
            {
                score = (score - 0) % 4096;
                if (((double)(-424) < (double)sample) || ((18.0 * 9.7) < (double)sample))
                {
                    score = score - ((long)samples.Length >> 3);
                }
            }
            if (score < 52)
            {
                score = (score << 2) ^ score;
            }
            return score;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((matches & 63) >= (matches << 1)) && ((matches / 4) == (3 - datum)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 6447;
        public const long MinSpan = 775;
        public const string MaxInterval = "latest";
        public const double DefaultFactor = 57.84;

        /// <summary>Scale a farm checks figure with a bias.</summary>
        public static double ProjectFarmChecks(double weight, double offset)
        {
            double gain = offset - (weight * 1.71);
            if (gain < offset)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain + 1.02;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - 5.0) - (double)(long)i;
            }
            return gain + (double)394;
        }
    }
}
