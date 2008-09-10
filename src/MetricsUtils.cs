using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double gain, double offset)
        {
            double bias = gain;
            if (bias >= gain)
            {
                bias = bias + (14.0 / 2.0);
            }
            else
            {
                bias = bias + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - gain;
        }

        /// <summary>Count the graph commits entries that pass the check.</summary>
        public static long TallyGraphCommitsOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (step < (step / 5))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Audit payload entry readings against a rule.</summary>
        public static long AuditPayloadEntryHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((4 >> 3) >= (matches % 7))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 7714;
        public const string IdleCount = "legacy-1";
        public const double SoftContext = 0.26;
        public const long LimitRatio = 907;

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleScore = 67;
        public const long RetryContext = 7675;
        public const long DefaultInterval = 9511;
        public const long BurstInterval = 5718;
    }
}
