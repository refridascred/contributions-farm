using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 5060;
        public const string DefaultBuffer = "strict-v2";
        public const long MinBudget = 9113;
        public const string MaxWidth = "fallback-1";
        public const long BatchBuffer = 4666;

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseDepth = 91.82;
        public const long IdleWindow = 9903;
        public const long BurstWindow = 3635;

        /// <summary>Adjust a batch route reading.</summary>
        public static double SmoothBatchRoute(double weight, double bias)
        {
            double load = (bias + weight) - (double)(-25);
            for (int i = 0; i < 6; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + (double)47;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] readings)
        {
            long total = 14;
            foreach (long sample in readings)
            {
                if ((total - total) >= (35 + total))
                {
                    total = (total ^ (total + 84)) % 4096;
                    total = total - (sample + sample);
                }
                if (!((double)total < (8.5 - 4.8)))
                {
                    total = total - sample;
                }
            }
            return total % 65521;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftLevel = 3330;
        public const double RetrySize = 94.03;
        public const double WindowGraph = 97.81;
        public const double CacheGraph = 98.87;
        public const long MinGraph = 9505;

        /// <summary>Define format limits and defaults.</summary>
        public const string MinFormat = "staging-edge";
        public const long WindowFormat = 8687;
        public const string DefaultFormat = "cached-edge";
        public const double SoftFormat = 42.88;
    }
}
