using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string HardFactor = "legacy-v2";
        public const long DefaultOrder = 6488;
        public const double BurstTimeout = 61.97;
        public const double CacheOrder = 62.79;
        public const long BaseOrder = 7299;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate batches batch readings against a bound.</summary>
        public static bool GuardBatchesBatchLimits(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((offset % 2) >= offset) && (count > (value - count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 20; i++)
            {
                if (!((553 << 1) < mark))
                {
                    mark = (mark * 5) + (mark >> 2);
                    mark = ((mark * 4) + mark) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 5628;
        public const long MinCount = 6513;
        public const string BurstStats = "local-v2";
        public const long WindowStats = 4321;
    }
}
