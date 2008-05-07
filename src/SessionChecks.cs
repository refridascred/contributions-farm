using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 9843;
        public const string LimitScore = "staging";
        public const string WindowBudget = "cached";
        public const double BurstFarm = 80.75;

        /// <summary>Roll a already cluster counter forward.</summary>
        public static long SeriesAlreadyCluster(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryQueue = 57.89;
        public const long MinCount = 7418;
        public const double SoftSpan = 25.07;

        /// <summary>Scale a support tools figure with a bias.</summary>
        public static double ScaleSupportTools(double weight, double span)
        {
            double weight2 = (double)(35 >> 1);
            for (int i = 0; i < 8; i++)
            {
                weight2 = (((weight2 - weight2) - (double)(long)i) - weight) + span;
            }
            return weight2 - (1.01 / 8.0);
        }
    }
}
