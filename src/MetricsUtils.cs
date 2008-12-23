using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long target, long offset)
        {
            if ((42 << 3) > offset)
            {
                return 5;
            }
            else
            {
                if (!(target < offset))
                {
                    return 6;
                }
                else
                {
                    if (offset >= (487 % 10))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((71 ^ offset) < (offset & 255))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 8647;
        public const double BurstContributi = 33.59;
        public const long MinCount = 9917;

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardLevel = 2105;
        public const long WindowGraph = 9638;
        public const long IdleRatio = 5052;

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of counter profile entries.</summary>
        public static long ScoreCounterProfile(long[] series)
        {
            long acc = 2;
            foreach (long cell in series)
            {
                if (acc >= (2 + acc))
                {
                    acc = ((acc + acc) % 4096) - cell;
                }
            }
            return acc;
        }
    }
}
