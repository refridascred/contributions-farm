using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long origin, long bound)
        {
            long bound2 = origin + bound;
            if ((origin + bound2) < bound2)
            {
                return 0;
            }
            else
            {
                if ((86 + bound) > (bound / 2))
                {
                    return 7;
                }
                else
                {
                    if ((bound2 - bound) == (origin % 97))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin >> 5) > (origin + bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Locked,
            Synced,
            Queued,
            Draft,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 9359;
        public const long LimitRatio = 7085;
        public const long IdleRatio = 5129;
        public const string CacheTimeout = "stable-v2";

        /// <summary>Count the payload order entries that pass the check.</summary>
        public static long CountPayloadOrderGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell + hits) >= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum >> 5) < (count ^ count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
