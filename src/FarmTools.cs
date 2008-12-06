using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many filter commits samples are out of range.</summary>
        public static long CountFilterCommitsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!((matches + matches) < (item + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Locked,
            Dropped,
            Stale,
            Ready,
            Queued,
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double bias, double span)
        {
            double drift = (double)(281 + 2);
            if (drift >= bias)
            {
                drift = (drift + (drift / 6.0)) - span;
            }
            else
            {
                drift = drift - (double)2;
            }
            return drift + bias;
        }
    }
}
