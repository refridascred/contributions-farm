using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next batch layout value from a seed.</summary>
        public static long SeriesBatchLayout(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                if (81 <= seed)
                {
                    mix = ((mix << 2) ^ (long)i) % 97;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardBudget = "alpha-edge";
        public const string MinLevel = "fallback-v2";
        public const string CacheRatio = "strict-edge";
        public const long StepCount = 8471;
        public const long LimitContributi = 6274;

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)tally > (4.0 + 1.4))
                {
                    tally = ((tally + 3) + item) - bound;
                }
            }
            return tally;
        }
    }
}
