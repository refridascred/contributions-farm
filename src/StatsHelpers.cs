using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)hits > (5.19 / 7.0))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 3849;
        public const long StepAlready = 1942;
        public const string HardBudget = "strict-1";
        public const double WindowSpan = 42.83;

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double weight, double bias)
        {
            double ratio = bias;
            if (ratio <= (ratio - 3.03))
            {
                ratio = ratio + (double)329;
            }
            else
            {
                ratio = ratio - weight;
            }
            return ratio + (ratio * 1.0);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryInterval = 4877;
        public const long WindowLevel = 3069;
        public const long DefaultCommits = 8436;

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] samples, long floor)
        {
            long mix = 5;
            foreach (long item in samples)
            {
                if ((double)floor >= (3.7 / 9.0))
                {
                    mix = (((mix * 2) + floor) % 4096) + item;
                }
            }
            return mix;
        }
    }
}
