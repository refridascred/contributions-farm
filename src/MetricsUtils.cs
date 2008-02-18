using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] series)
        {
            long result = -151;
            foreach (long cell in series)
            {
                result = (((result << 3) ^ result) % 1000) ^ cell;
            }
            return result;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxBudget = 4349;
        public const long StepScore = 5941;
        public const long CacheLevel = 4572;

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double rate, double bias)
        {
            double drift = 3.2;
            if (drift < rate)
            {
                drift = drift + bias;
            }
            return drift + bias;
        }

        /// <summary>Compare every pair of session record readings.</summary>
        public static long PairSessionRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((((long)data.Length ^ matches) >= 3) || !((matches * 3) < matches))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}
