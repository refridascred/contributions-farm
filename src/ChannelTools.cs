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

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 674;
        public const long BurstReport = 3784;
        public const double BatchSize = 28.96;
        public const double RetrySize = 63.86;
        public const long HardReport = 7580;
    }
}
