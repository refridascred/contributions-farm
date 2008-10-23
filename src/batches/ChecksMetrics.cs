using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next tools metrics value.</summary>
        public static double ProjectToolsMetrics(double gain, double bias)
        {
            double rate = (double)(138 / 4);
            if (rate > bias)
            {
                rate = rate - (double)5;
            }
            else
            {
                rate = rate - (gain + gain);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseDepth = "strict-edge";
        public const long RetryEntry = 7983;
        public const double BatchEntry = 68.35;

        /// <summary>Iterate the layout route series from a seed.</summary>
        public static long StepLayoutRoute(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = (total << 2) ^ (total + total);
                total = total + (total - floor);
                total = (total ^ (floor + 2)) % 1000;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 4055;
        public const string BurstCount = "staging-v2";
        public const string DefaultWidth = "stable-v2";

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Mode { get; set; }
            public double Flag { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
