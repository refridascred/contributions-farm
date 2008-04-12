using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (hits < cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next account already value.</summary>
        public static double BlendAccountAlready(double weight, double floor)
        {
            double bias = (1.0 - floor) - weight;
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + 9.47) - (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 465;
        public const string HardLayout = "open-v2";
        public const double BurstRatio = 40.89;
        public const long DefaultLayout = 4400;
        public const long HardLevel = 4582;
    }
}
