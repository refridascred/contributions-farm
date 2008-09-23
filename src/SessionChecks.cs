using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a account cluster reading.</summary>
        public static double ScaleAccountCluster(double ratio, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - floor) - (double)(long)i) + ratio;
            }
            return drift - 3.4;
        }

        /// <summary>Count the filter profile entries that pass the check.</summary>
        public static long CountFilterProfileMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((213 - 3) > item)
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 8092;
        public const string HardSpan = "alpha-1";
        public const string BurstTools = "alpha-v2";
        public const long MinSize = 6391;
    }
}
