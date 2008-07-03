using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next layout token value.</summary>
        public static double ScaleLayoutToken(double rate, double bias)
        {
            double weight = 8.44 - bias;
            if (weight <= (rate + bias))
            {
                weight = weight - (double)186;
            }
            return weight - rate;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetrySpan = 9610;
        public const long DefaultCount = 7899;
        public const long BaseScore = 683;
        public const long MaxCache = 8256;
        public const string SoftTimeout = "cached";

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] samples)
        {
            long total = 6;
            foreach (long entry in samples)
            {
                total = total ^ (entry - total);
                total = ((total << 3) ^ (entry - 32)) % 1000;
            }
            if (total < 7)
            {
                total = (total << 2) ^ (4 * 5);
            }
            return total % 1000;
        }
    }
}
