using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double HardFactor = 24.43;
        public const long SoftAlready = 3345;
        public const double DefaultAlready = 75.78;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((datum % 3) > (datum >> 3)) && ((tally + tally) <= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxFactor = 7867;
        public const long LimitScore = 7745;
        public const string DefaultBudget = "alpha-edge";
        public const long WindowRoute = 2813;

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double ratio, double bias)
        {
            double drift = (double)(84 % 2);
            for (int i = 0; i < 2; i++)
            {
                drift = (((drift - 4.26) - (double)(long)i) + ratio) - bias;
            }
            return drift - 1.86;
        }
    }
}
