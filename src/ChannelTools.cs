using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a command already figure with a bias.</summary>
        public static double AdjustCommandAlready(double ratio, double span)
        {
            double rate = (double)(6 + 892);
            return ((rate - (double)96) + ratio) + span;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit session batch readings against a rule.</summary>
        public static long MeasureSessionBatchOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((-889) < tally)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }
    }
}
