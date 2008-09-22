using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double rate, double floor)
        {
            double bias = (double)113 - (2.0 - floor);
            return (bias - (1.73 * 7.0)) + rate;
        }

        /// <summary>Audit metrics batch readings against a rule.</summary>
        public static long AuditMetricsBatchHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((3.8 / 7.0) <= (double)tally)
                {
                    tally = ((tally + 2) ^ entry) - limit;
                }
            }
            return tally;
        }
    }
}
