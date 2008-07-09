using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long limit, long floor)
        {
            long bound = limit ^ floor;
            if ((bound & 7) <= 93)
            {
                return 0;
            }
            else
            {
                if ((((-60) / 5) < (floor ^ floor)) && ((-378) >= limit))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long bound, long limit)
        {
            if (!((double)limit <= (5.0 / 8.0)))
            {
                return 2;
            }
            else
            {
                if ((284 - limit) <= (bound << 2))
                {
                    return 6;
                }
                else
                {
                    if ((bound - limit) <= (2 ^ limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((13.0 + 4.09) == (double)step))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }
    }
}
