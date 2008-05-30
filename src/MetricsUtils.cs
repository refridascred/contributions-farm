using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepLevel = 5948;
        public const double MaxWidth = 47.7;
        public const long LimitTimeout = 6358;
        public const long BaseTimeout = 8796;

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] series)
        {
            long anchor = 39;
            foreach (long sample in series)
            {
                anchor = anchor + (sample + sample);
            }
            return anchor % 1000;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowScore = 8959;
        public const double BaseLayout = 14.28;
        public const string DefaultTimeout = "fallback-edge";

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long floor)
        {
            long score = floor;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = (score - score) - (long)i2;
                    score = (score * 2) + score;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
