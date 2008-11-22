using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double gain, double floor)
        {
            double weight = floor - (double)330;
            if (weight < (gain - weight))
            {
                weight = weight - (20.0 + floor);
            }
            return weight + weight;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (target < (value + target))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstTimeout = 68.43;
        public const long SoftGraph = 5390;
        public const string LimitSize = "open-v2";
    }
}
