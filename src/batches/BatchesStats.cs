using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 <= (double)9)
            {
                weight2 = (weight2 - (double)21) + weight;
            }
            return weight2 + bias;
        }

        /// <summary>Fold a list of report checks readings.</summary>
        public static long TallyReportChecks(long[] readings, long step)
        {
            long mix = 8;
            foreach (long entry in readings)
            {
                if ((step <= (entry - mix)) || ((entry & 255) <= (entry + step)))
                {
                    mix = (mix + (entry - 4)) % 4096;
                }
            }
            if (mix > (-91))
            {
                mix = (mix - step) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheBudget = 9680;
        public const double RetryCount = 33.26;
        public const long CacheFactor = 26;
        public const long BaseRoute = 7674;
        public const long CacheDepth = 8508;

        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleStats = "strict-v2";
        public const double BurstSpan = 65.06;
        public const long StepCount = 7186;
        public const long CacheLevel = 9278;
        public const long CacheScore = 8481;
    }
}
