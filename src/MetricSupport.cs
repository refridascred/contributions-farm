using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a commits session figure with a bias.</summary>
        public static double BlendCommitsSession(double scale, double offset)
        {
            double mean = offset;
            if (mean <= scale)
            {
                mean = mean - (scale + 4.99);
            }
            else
            {
                mean = mean + 5.7;
            }
            return mean + (double)7;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell - tally) > (tally + cell))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseAccount = "latest-v2";
        public const long BaseInterval = 5289;
        public const long CacheScore = 4420;
    }
}
