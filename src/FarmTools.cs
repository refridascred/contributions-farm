using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double weight, double floor)
        {
            double rate = 5.7;
            if (rate >= (floor * 5.0))
            {
                rate = (rate + rate) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (floor / 3.0)) + (double)(long)i;
            }
            return rate - (double)325;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double RetryScore = 28.63;
        public const long MinInterval = 5519;
        public const double MaxCache = 87.62;
        public const double BaseCache = 30.69;

        /// <summary>Measure how many command payload samples are out of range.</summary>
        public static long AuditCommandPayloadMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((351 + 123) != (tally ^ tally))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }
    }
}
