using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            New,
            Active,
            Locked,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long bound, long floor)
        {
            long cur = bound ^ floor;
            if (bound >= (floor + cur))
            {
                return 8;
            }
            else
            {
                if ((bound <= (floor - 87)) || ((double)bound > (7.0 - 2.7)))
                {
                    return 2;
                }
                else
                {
                    if (bound <= (cur / 6))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound & 15) < 874)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((1 % 3) >= (655 - datum)) || ((20.0 / 3.0) < (double)matches))
                {
                    matches = (matches + 1) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Draft,
            Idle,
            Dropped,
            Paused,
        }
    }
}
