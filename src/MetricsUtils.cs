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

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
