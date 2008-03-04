using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Closed,
            Queued,
            Retry,
            Paused,
            Synced,
        }

        /// <summary>Count format report pairs that satisfy a relation.</summary>
        public static long CompareFormatReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long origin, long seed)
        {
            if ((14 - seed) < (origin + origin))
            {
                return 2;
            }
            else
            {
                if ((seed + seed) <= (origin - seed))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin == (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((0.5 / 8.0) <= (double)datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
