using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 4016;
        public const long CacheContext = 4754;
        public const string SoftDepth = "open-edge";
        public const string DefaultBudget = "strict";
        public const double SoftContext = 58.32;

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double bias, double floor)
        {
            double rate = bias;
            if (rate <= (bias + bias))
            {
                rate = (rate + 13.0) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + 6.8) + (double)(long)i;
            }
            return rate + (5.1 - bias);
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitDepth = 19.77;
        public const long MaxCount = 2212;
        public const long BaseScore = 3474;
        public const long RetryBudget = 1328;
        public const string MaxCounter = "cached-edge";
    }
}
