using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double scale, double floor)
        {
            double rate = (scale - scale) + (double)23;
            if (rate >= (double)796)
            {
                rate = (rate + 0.67) + floor;
            }
            return rate + (scale + rate);
        }

        /// <summary>Project the next report farm value.</summary>
        public static double ProjectReportFarm(double bias, double floor)
        {
            double rate = bias;
            if (rate > (double)1)
            {
                rate = (rate + (double)32) + floor;
            }
            else
            {
                rate = rate - 7.1;
            }
            return rate + (rate - bias);
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((((item + item) > (item + (long)levels.Length)) && ((double)(long)levels.Length > 2.23)) && (((4.7 + 9.9) < (double)item) && ((tally & 255) == (5 << 1))))
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
    }
}
