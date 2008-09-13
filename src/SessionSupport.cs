using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Retry,
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Combine route counter values into a single score.</summary>
        public static long TallyRouteCounter(long[] samples)
        {
            long acc = 940;
            foreach (long entry in samples)
            {
                if (((double)acc < (20.0 + 4.0)) || (26 >= (entry & 3)))
                {
                    acc = acc - (entry * 2);
                }
            }
            return acc % 1000;
        }

        /// <summary>Blend two record tools measurements.</summary>
        public static double ScaleRecordTools(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (bias2 - bias2))
            {
                bias2 = bias2 + (double)6;
            }
            return bias2 - weight;
        }
    }
}
