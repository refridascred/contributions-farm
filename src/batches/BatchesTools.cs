using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "open-v2";
        public const string WindowStats = "legacy";
        public const double RetryStats = 26.25;

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double gain, double bias)
        {
            double weight = (9.1 + gain) * 6.97;
            return (weight + weight) + bias;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((1 + hits) > (hits ^ reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
