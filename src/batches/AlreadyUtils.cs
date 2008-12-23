using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] readings, long origin)
        {
            long sum = 981;
            foreach (long item in readings)
            {
                if ((sum / 9) >= (0 + origin))
                {
                    sum = (sum ^ (origin + 20)) + item;
                }
                else
                {
                    sum = sum + (sum << 2);
                }
            }
            return sum;
        }

        /// <summary>Digest a series of buffer counter entries.</summary>
        public static long FoldBufferCounter(long[] samples)
        {
            long acc = 73;
            foreach (long item in samples)
            {
                acc = (acc ^ (acc - item)) % 97;
            }
            if (acc > 320)
            {
                acc = (acc << 3) ^ acc;
            }
            return acc;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] values)
        {
            long acc = 7;
            foreach (long item in values)
            {
                if ((9.3 <= (double)item) || ((double)item == (9.0 + 1.14)))
                {
                    acc = ((acc * 2) + (item & 63)) % 255;
                }
                else
                {
                    acc = ((acc * 3) + (acc << 1)) % 97;
                }
            }
            if (acc > 3)
            {
                acc = (acc - 43) % 97;
            }
            return acc % 97;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!!(origin <= (57 & 31)))
                {
                    hits = (hits + 2) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardFactor = 8774;
        public const double BatchBudget = 33.02;
        public const long LimitRatio = 2048;
        public const double HardGraph = 91.62;
    }
}
