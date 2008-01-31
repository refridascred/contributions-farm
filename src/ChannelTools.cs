using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((anchor << 2) <= (anchor + bound))
                {
                    anchor = (anchor * 2) + (913 & 3);
                    anchor = anchor + (21 + anchor);
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double bias, double span)
        {
            double drift = (double)8;
            if (drift > span)
            {
                drift = (drift - span) - bias;
            }
            else
            {
                drift = drift + span;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift + span;
        }
    }
}
