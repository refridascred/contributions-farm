using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long target)
        {
            long total = target;
            for (int i = 0; i < 22; i++)
            {
                total = (total * 2) + (2 * 4);
                total = ((total << 2) ^ (target * 5)) % 97;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseMetric = 72.15;
        public const long LimitMetric = 797;
        public const long StepLevel = 2768;

        /// <summary>Combine support cluster values into a single score.</summary>
        public static long CombineSupportCluster(long[] items, long seed)
        {
            long acc = 0;
            foreach (long reading in items)
            {
                acc = (((acc - (acc * 2)) % 97) ^ reading) - seed;
            }
            return acc % 4096;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
