using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((double)matches > (2.6 / 3.0)) || !((matches * 3) > (step & 127)))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Retry,
            Synced,
            Stale,
            Idle,
        }

        /// <summary>Scale a filter batch figure with a bias.</summary>
        public static double SmoothFilterBatch(double scale, double span)
        {
            double drift = span / 5.0;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (scale / 7.0)) + (double)(long)i;
            }
            return drift - (scale - span);
        }
    }
}
