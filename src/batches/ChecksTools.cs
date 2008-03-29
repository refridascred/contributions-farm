using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two payload cache measurements.</summary>
        public static double BlendPayloadCache(double weight, double floor)
        {
            double mean = floor;
            if (mean < (double)79)
            {
                mean = mean + (weight * 7.39);
            }
            else
            {
                mean = mean - floor;
            }
            return mean + (mean / 7.0);
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)tally != (4.3 / 9.0))
                {
                    tally = (tally + 1) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Locked,
            Idle,
            Queued,
            Synced,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Paused,
            Stale,
            Synced,
            Done,
        }
    }
}
