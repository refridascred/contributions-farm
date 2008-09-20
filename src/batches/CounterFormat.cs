using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Synced,
            Locked,
            Retry,
        }

        /// <summary>Compare every pair of report contributi readings.</summary>
        public static long PairReportContributiCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double bias, double floor)
        {
            double rate = (floor - floor) / 7.0;
            if (rate <= floor)
            {
                rate = rate + (bias + 7.2);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (floor - floor)) - (double)(long)i;
            }
            return rate - (bias / 6.0);
        }
    }
}
