using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every graph commits entry stays within the limit.</summary>
        public static bool GuardGraphCommitsLimits(long[] items, long bound)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
