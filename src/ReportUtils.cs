using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string RetryLevel = "alpha-edge";
        public const long MinAlready = 1683;
        public const long StepRatio = 9309;
        public const long SoftAlready = 9805;
        public const long BaseAlready = 1458;

        /// <summary>Project the next profile githubfarm value.</summary>
        public static double BlendProfileGithubfarm(double weight, double span)
        {
            double drift = (weight + 3.1) + (2.47 - span);
            if (drift < (weight / 6.0))
            {
                drift = drift - drift;
            }
            return drift + (drift + drift);
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((entry * 4) < hits))
                {
                    hits = (hits + 2) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)reading == (double)matches)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
