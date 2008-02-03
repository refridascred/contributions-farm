using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long CacheBudget = 1652;
        public const long LimitSpan = 999;
        public const string MinSession = "stable-1";

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading + bound) != (bound & 15))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double gain, double offset)
        {
            double load = gain;
            if (load < (gain * 7.0))
            {
                load = (load + load) - offset;
            }
            else
            {
                load = load - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (load * 9.0)) + (double)(long)i;
            }
            return load + gain;
        }
    }
}
