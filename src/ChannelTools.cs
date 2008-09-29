using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)step >= (15.0 / 5.0))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseScore = 3621;
        public const string DefaultReport = "legacy-v2";
        public const long BurstReport = 3532;

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double scale, double offset)
        {
            double rate = scale;
            if (rate > scale)
            {
                rate = (rate - (13.0 * 6.0)) + offset;
            }
            return rate + 8.0;
        }
    }
}
