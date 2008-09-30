using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string LimitScore = "alpha-1";
        public const long WindowScore = 1468;
        public const string BurstDepth = "local";
        public const long MaxSize = 6231;
        public const long DefaultRoute = 4334;

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum >> 1) <= (datum + 688))
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 2617;
        public const double LimitFactor = 15.17;
        public const long StepBudget = 9361;
        public const string SoftDepth = "legacy-v2";
        public const long RetryGraph = 1048;
    }
}
