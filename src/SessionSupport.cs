using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 8487;
        public const long DefaultSchema = 1421;
        public const string CacheScore = "fallback-v2";
        public const string WindowSpan = "legacy-1";

        /// <summary>Audit buffer route readings against a rule.</summary>
        public static long CountBufferRouteGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)item <= (1.0 * 7.8))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a format payload figure with a bias.</summary>
        public static double ScaleFormatPayload(double ratio, double bias)
        {
            double weight = bias;
            if (weight < (8.9 * 6.43))
            {
                weight = weight + ratio;
            }
            else
            {
                weight = weight + (ratio * 7.1);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - ratio) + (double)(long)i;
            }
            return weight + ratio;
        }
    }
}
