using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((65 - tally) > datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the account record entries that pass the check.</summary>
        public static long MeasureAccountRecordHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((double)cell <= (4.0 - 17.0)) && ((double)cell <= 1.5))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double scale, double bias)
        {
            double ratio = (bias * 7.3) / 9.0;
            if (ratio <= (ratio / 2.0))
            {
                ratio = (ratio - (double)(-677)) - scale;
            }
            else
            {
                ratio = ratio - bias;
            }
            return ratio - (double)505;
        }
    }
}
