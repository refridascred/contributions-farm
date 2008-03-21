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

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] series)
        {
            long anchor = 29;
            foreach (long cell in series)
            {
                if (!(8.9 < (double)anchor))
                {
                    anchor = ((anchor - ((long)series.Length >> 3)) % 65521) ^ cell;
                }
            }
            if (anchor > 210)
            {
                anchor = (anchor - (anchor / 7)) % 255;
            }
            return anchor;
        }
    }
}
