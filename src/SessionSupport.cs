using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate channel graph samples.</summary>
        public static long ScoreChannelGraph(long[] data)
        {
            long mark = -135;
            foreach (long entry in data)
            {
                mark = (mark - entry) % 101;
            }
            return mark;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((double)tally <= (9.7 * 7.96)))
                {
                    tally = (tally + 2) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double rate, double offset)
        {
            double load = (9.0 / 8.0) * 4.15;
            return ((load + (load - load)) + rate) + offset;
        }
    }
}
