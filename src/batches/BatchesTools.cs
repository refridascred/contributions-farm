using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string StepRoute = "standard";
        public const long WindowRoute = 7218;
        public const double BurstRoute = 91.11;
        public const long CacheFactor = 3337;

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 5973;
        public const string BaseEntry = "fallback-edge";
        public const long StepCount = 141;
        public const long LimitEntry = 2103;
    }
}
