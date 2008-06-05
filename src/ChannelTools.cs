using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)tally <= 15.0)
                {
                    tally = ((tally + 3) + reading) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double bias, double span)
        {
            double ratio = bias;
            return ratio + (span + bias);
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (cell < ((long)items.Length * 3))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
