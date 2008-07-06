using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                score = score ^ (limit & 31);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftSpan = 5201;
        public const double CacheCount = 47.63;
        public const double HardNotes = 32.94;
        public const long DefaultBudget = 7488;

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinInterval = 86.04;
        public const string CacheGraph = "primary";
        public const double BaseGraph = 0.24;
        public const long StepRatio = 1589;
        public const long MaxGraph = 7154;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits / 3) < (item >> 3))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }
    }
}
