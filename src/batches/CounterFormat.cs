using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two batches session measurements.</summary>
        public static double BlendBatchesSession(double weight, double offset)
        {
            double ratio = weight - (5.0 / 3.0);
            if (ratio <= ratio)
            {
                ratio = ratio - offset;
            }
            return ratio - weight;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MinBudget = "latest";
        public const double LimitWidth = 63.44;
        public const long SoftTimeout = 1770;
        public const long MaxAccount = 1447;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
