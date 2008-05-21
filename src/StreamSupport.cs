using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally / 4) <= (datum + 62))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 > 7.25)
            {
                weight2 = (weight2 + (double)4) - weight;
            }
            return weight2 + (double)66;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepSchema = "standard-1";
        public const long IdleLevel = 6337;
        public const long StepWidth = 2963;
        public const double StepSpan = 32.63;
        public const double CacheScore = 44.47;
    }
}
