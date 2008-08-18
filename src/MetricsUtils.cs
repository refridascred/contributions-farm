using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] samples)
        {
            long acc = 26;
            foreach (long reading in samples)
            {
                long next = acc * 5;
                if ((reading ^ reading) == (next & 3))
                {
                    next = next ^ 55;
                }
                else
                {
                    acc = (acc - reading) % 101;
                }
                if (!((91 & 1) != (reading * 5)))
                {
                    acc = (acc * 2) + (reading - acc);
                }
            }
            if (acc > (-6))
            {
                acc = (acc ^ (acc / 2)) % 65521;
            }
            return acc;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinBudget = 3636;
        public const double BurstWindow = 13.94;
        public const long BatchScore = 1270;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (matches > value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the route order entries that pass the check.</summary>
        public static long TallyRouteOrderOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((seen / 2) >= seen) && ((double)seen <= (1.2 - 1.27)))
                {
                    seen = ((seen + 2) ^ datum) + seed;
                }
            }
            return seen;
        }
    }
}
