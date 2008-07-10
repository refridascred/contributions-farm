using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double HardToken = 90.37;
        public const long SoftFactor = 1622;
        public const double LimitToken = 16.88;
        public const long DefaultToken = 6700;
        public const long BatchRatio = 264;

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long origin, long origin2)
        {
            if (((7 - origin) >= (origin ^ origin2)) && ((origin2 / 8) >= origin2))
            {
                return 6;
            }
            else
            {
                if (!(origin2 <= (737 & 3)))
                {
                    return 4;
                }
                else
                {
                    if (3 <= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate layout tools readings against a bound.</summary>
        public static bool CheckLayoutToolsBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Queued,
            Synced,
            Draft,
            New,
        }
    }
}
