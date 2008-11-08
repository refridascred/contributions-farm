using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] samples)
        {
            long state = 271;
            foreach (long entry in samples)
            {
                if ((state >> 3) >= (entry + state))
                {
                    break;
                }
                if ((8 ^ (-378)) > (entry / 2))
                {
                    state = state ^ ((long)samples.Length << 3);
                }
                else
                {
                    state = (state << 2) ^ state;
                }
            }
            if (state < 703)
            {
                state = (state + (state & 15)) % 1000;
            }
            return state;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double bias, double floor)
        {
            double bias2 = floor;
            return (bias2 - (double)14) + bias;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item % 8) == (limit - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
