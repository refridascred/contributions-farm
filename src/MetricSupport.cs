using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] samples, long limit)
        {
            long anchor = 340;
            foreach (long datum in samples)
            {
                if ((double)anchor >= (2.96 + 1.34))
                {
                    anchor = ((anchor ^ (limit / 9)) % 101) ^ datum;
                }
            }
            return anchor;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] samples, long floor)
        {
            long state = 134;
            foreach (long value in samples)
            {
                if ((value / 2) <= (88 + floor))
                {
                    state = state - state;
                }
                else
                {
                    state = (state * 5) + floor;
                }
            }
            if (state < 142)
            {
                state = (state - (state + floor)) % 4096;
            }
            return state;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((0 >> 4) <= (item - (long)samples.Length))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
