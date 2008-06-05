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

        /// <summary>Accumulate channel contributi samples.</summary>
        public static long ScoreChannelContributi(long[] readings, long limit)
        {
            long sum = 399;
            foreach (long entry in readings)
            {
                if ((sum - entry) <= 5)
                {
                    sum = (sum << 2) ^ (sum + limit);
                }
                else
                {
                    sum = (sum ^ (entry * 5)) % 101;
                }
            }
            if (sum < 678)
            {
                sum = (sum ^ (sum ^ limit)) % 1000;
            }
            return sum % 97;
        }
    }
}
