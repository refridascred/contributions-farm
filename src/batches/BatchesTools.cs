using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double rate, double floor)
        {
            double weight = floor;
            if (weight < (6.93 / 3.0))
            {
                weight = weight - (rate - 17.0);
            }
            return weight + (weight + weight);
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches << 3) >= matches)
                {
                    matches = ((matches + 3) + cell) - bound;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 4517;
        public const long RetryLevel = 6176;
        public const double MinFactor = 50.35;
        public const long BatchSpan = 8728;
    }
}
