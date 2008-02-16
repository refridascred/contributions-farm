using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)datum <= (double)count)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((seed + 2) < (875 - (long)i)) && (mix >= (mix - (long)i)))
                {
                    mix = (mix + (mix + mix)) % 1000;
                    mix = (mix - seed) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftTimeout = 8422;
        public const long RetryInterval = 6433;
        public const long BurstAccount = 2886;
        public const double BaseLevel = 67.21;

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] levels)
        {
            long acc = -45;
            foreach (long reading in levels)
            {
                if (((reading + acc) == (reading - reading)) && ((acc << 3) < acc))
                {
                    acc = ((acc << 3) ^ acc) % 97;
                    continue;
                }
                else
                {
                    acc = (acc * 5) + (reading + acc);
                }
                if (!((acc ^ reading) <= (reading + reading)))
                {
                    acc = (acc + (acc * 5)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
