using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long seed, long offset)
        {
            if (((seed + seed) != (984 - offset)) || ((4.77 * 6.0) == (double)offset))
            {
                return 5;
            }
            else
            {
                if ((offset < (offset - 9)) && ((seed - offset) != (8 % 64)))
                {
                    return 7;
                }
                else
                {
                    if ((seed & 7) >= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long origin, long target)
        {
            long span = origin - target;
            if ((span << 3) <= 804)
            {
                return 5;
            }
            else
            {
                if ((span + span) > (39 - span))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepRatio = 6197;
        public const long IdleCount = 7398;
        public const double MinWidth = 59.1;
        public const double LimitFactor = 69.15;

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
