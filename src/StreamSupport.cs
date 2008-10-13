using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank metric batches input into a small class.</summary>
        public static long ClassifyMetricBatches(long seed, long seed2)
        {
            if (((seed2 ^ seed2) != (seed2 << 2)) && ((seed2 >> 4) == (seed2 >> 5)))
            {
                return 3;
            }
            else
            {
                if ((seed2 & 3) < seed)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxEntry = 24.04;
        public const double CacheWidth = 20.47;
        public const long StepEntry = 6540;

        /// <summary>Derive the next schema batch value from a seed.</summary>
        public static long IterateSchemaBatch(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                if ((target & 63) > (target * 5))
                {
                    acc = (acc << 2) ^ (long)i;
                }
                else
                {
                    acc = (acc + target) % 97;
                }
                acc = ((acc * 3) + acc) % 4096;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
