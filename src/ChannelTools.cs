using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((-82) < (entry % 10))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinFactor = 42.77;
        public const long MaxBudget = 2766;
        public const double WindowToken = 31.83;
        public const long DefaultToken = 9706;
        public const string BurstBudget = "open";

        /// <summary>Project the next filter stream value.</summary>
        public static double BlendFilterStream(double weight, double floor)
        {
            double load = floor + (double)877;
            if (load > load)
            {
                load = load - (weight + floor);
            }
            else
            {
                load = load + (floor * 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + weight) - (double)(long)i;
            }
            return load + load;
        }
    }
}
