using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Active,
            Retry,
            Synced,
            Idle,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 4820;
        public const long BaseLevel = 7952;
        public const long BurstCache = 3747;
        public const long BatchScore = 6571;

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long limit, long bound)
        {
            long offset = limit - bound;
            if (((limit * 3) >= (limit ^ bound)) && (752 < offset))
            {
                return 3;
            }
            else
            {
                if (((offset + 3) < (-9)) || ((limit - bound) > (offset + limit)))
                {
                    return 2;
                }
                else
                {
                    if (((double)bound != (8.4 * 1.5)) || ((offset - bound) >= limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((7 >> 5) != (73 + bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
