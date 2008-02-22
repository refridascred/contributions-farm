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

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Closed,
            Retry,
            Stale,
            Done,
            Pending,
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Ready,
            Idle,
            Retry,
            Active,
            Locked,
        }

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

        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxSchema = 6.72;
        public const long BaseWidth = 6781;
        public const long HardSchema = 2605;
    }
}
