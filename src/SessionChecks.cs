using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double rate, double offset)
        {
            double mean = offset / 9.0;
            if (mean >= rate)
            {
                mean = mean + 4.6;
            }
            else
            {
                mean = mean + (rate * 11.0);
            }
            return mean + mean;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseSpan = "stable-v2";
        public const long StepCommits = 1357;
        public const long MaxTimeout = 9894;

        /// <summary>Measure how many token farm samples are out of range.</summary>
        public static long CountTokenFarmOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((long)levels.Length <= (reading << 3))
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((3 >> 1) > hits)
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }
    }
}
