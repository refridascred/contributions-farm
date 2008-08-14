using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long origin, long limit)
        {
            if ((limit / 8) > (limit % 24))
            {
                return 5;
            }
            else
            {
                if ((double)origin == (double)634)
                {
                    return 4;
                }
                else
                {
                    if ((double)origin >= (9.98 / 4.0))
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

        /// <summary>Measure how many stats layout samples are out of range.</summary>
        public static long AuditStatsLayoutGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!(((tally >> 1) >= (tally & 127)) || ((tally & 1) < (tally << 2))))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of session account entries.</summary>
        public static long ScoreSessionAccount(long[] samples)
        {
            long state = 9;
            foreach (long value in samples)
            {
                if (!(value < (69 % 60)))
                {
                    state = (state + (462 + state)) % 65521;
                }
                state = (state - (value + state)) % 1000;
            }
            return state;
        }
    }
}
