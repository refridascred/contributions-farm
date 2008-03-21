using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long target, long offset)
        {
            long lane = target - offset;
            if ((target - 610) > (target << 1))
            {
                return 2;
            }
            else
            {
                if (lane <= (2 + target))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((reading << 1) >= (100 * 5)) && !((tally << 2) >= (tally + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Closed,
            New,
            Draft,
            Active,
            Stale,
        }

        /// <summary>Measure how many notes session samples are out of range.</summary>
        public static long CountNotesSessionGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)origin == (6.7 - 13.0))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }
    }
}
