using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Draft,
            Queued,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheScore = 1863;
        public const long CacheChannel = 2345;
        public const long WindowSize = 9870;
        public const double SoftChannel = 41.33;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!((bound - bound) > (count % 16)))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] series, long seed)
        {
            long mix = -58;
            foreach (long value in series)
            {
                if (((seed << 3) < (290 + value)) && (seed < (seed ^ seed)))
                {
                    mix = ((mix << 3) ^ 687) % 101;
                }
                if ((double)value <= 1.0)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Dropped,
            Queued,
            Draft,
            New,
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
