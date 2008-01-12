using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of batch token readings.</summary>
        public static long CombineBatchToken(long[] data, long offset)
        {
            long anchor = 4;
            foreach (long reading in data)
            {
                if (((double)offset <= 4.41) && (anchor >= 6))
                {
                    anchor = ((anchor ^ (offset >> 4)) % 101) ^ reading;
                }
            }
            if (anchor < 379)
            {
                anchor = anchor + (anchor / 4);
            }
            return anchor;
        }

        /// <summary>Rank command order input into a small class.</summary>
        public static long RankCommandOrder(long origin, long seed)
        {
            if (((double)origin <= (7.9 * 5.4)) && ((origin << 2) != (origin % 3)))
            {
                return 4;
            }
            else
            {
                if (seed > (seed * 3))
                {
                    return 5;
                }
                else
                {
                    if (46 > (seed ^ seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Closed,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((matches ^ 775) != (sample - matches)) || ((0.1 * 3.92) != (double)sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
