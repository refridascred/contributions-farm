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

        /// <summary>Define route limits and defaults.</summary>
        public const double MinRoute = 37.65;
        public const string WindowRoute = "local-1";
        public const long BurstFactor = 2821;
        public const long IdleTimeout = 2070;
        public const long BurstRoute = 6821;
    }
}
