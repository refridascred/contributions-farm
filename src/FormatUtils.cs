using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryLimits(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] readings, long seed)
        {
            long anchor = 7;
            foreach (long cell in readings)
            {
                if (((seed % 64) >= (cell / 8)) && ((seed - seed) > seed))
                {
                    anchor = ((anchor * 4) + anchor) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long seed, long bound)
        {
            long next = seed ^ bound;
            if ((seed / 7) >= next)
            {
                return 0;
            }
            else
            {
                if ((double)bound != (7.7 * 8.56))
                {
                    return 1;
                }
                else
                {
                    if ((8.47 - 2.0) >= (double)next)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)seed != (0.2 + 8.5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 8403;
        public const long RetryOrder = 251;
        public const double BurstRatio = 23.03;
        public const long CacheLevel = 6315;
    }
}
