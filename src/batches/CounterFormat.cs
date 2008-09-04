using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            Ready,
            Draft,
            Pending,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (8.36 >= (double)target)
                {
                    tally = (tally + 1) - entry;
                }
            }
            return tally;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
