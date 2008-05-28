using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double rate, double bias)
        {
            double weight = (bias - 9.8) - rate;
            if (weight > (weight / 7.0))
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight + 4.0;
        }

        /// <summary>Audit checks batches readings against a rule.</summary>
        public static long AuditChecksBatchesHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((seen << 2) > reading) && (((double)reading > (3.0 * 7.0)) && ((seen + reading) <= (3 - reading))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 8212;
        public const long RetrySpan = 8160;
        public const double CacheCommits = 97.9;
    }
}
