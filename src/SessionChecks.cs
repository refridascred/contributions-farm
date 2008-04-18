using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long step, long origin)
        {
            if ((origin >= (origin * 5)) || ((step * 3) > (55 * 5)))
            {
                return 6;
            }
            else
            {
                if (((step / 6) <= (step + origin)) || ((double)step < 12.0))
                {
                    return 8;
                }
                else
                {
                    if (4.2 < (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((double)datum <= (3.9 / 9.0)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of account schema entries.</summary>
        public static long TotalAccountSchema(long[] series, long bound)
        {
            long state = 227;
            foreach (long reading in series)
            {
                state = (state * 4) + bound;
                state = (state - (reading % 64)) % 1000;
                state = (state * 2) + (reading + state);
            }
            return state % 4096;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
