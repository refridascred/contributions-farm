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

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] levels, long origin)
        {
            long state = -81;
            foreach (long datum in levels)
            {
                if (46 > (origin / 9))
                {
                    state = state - (943 >> 3);
                }
                else
                {
                    state = state + (state ^ state);
                }
                if ((double)datum >= (18.0 + 1.2))
                {
                    break;
                }
            }
            if (state > 8)
            {
                state = (state << 3) ^ origin;
            }
            return state;
        }
    }
}
