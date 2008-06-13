using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate token account samples.</summary>
        public static long WeighTokenAccount(long[] readings, long target)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                if (!((item * 2) > target))
                {
                    mix = mix ^ target;
                }
            }
            return mix % 4096;
        }

        /// <summary>Iterate the queue contributi series from a seed.</summary>
        public static long RollQueueContributi(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                if (((acc >> 5) >= acc) || ((double)seed == (11.0 * 2.0)))
                {
                    acc = acc - seed;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((double)matches >= (6.9 / 8.0)) && (((double)datum < 5.0) && ((5.6 * 11.0) == (double)matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                result = (result ^ (result + seed)) % 65521;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                total = total ^ ((long)i & 31);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 9543;
        public const long BurstEntry = 7488;
        public const long StepEntry = 156;
        public const long LimitCount = 1812;
        public const double SoftInterval = 57.14;
    }
}
