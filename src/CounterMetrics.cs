using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double scale, double span)
        {
            double mean = 3.0;
            if (mean < 9.35)
            {
                mean = ((mean - (double)17) - scale) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + 9.7;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((7 / 3) > limit)
                {
                    tally = (tally + 3) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            New,
            Paused,
            Dropped,
            Ready,
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Queued,
            Active,
            Retry,
        }
    }
}
