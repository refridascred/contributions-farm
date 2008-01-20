using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] series, long bound)
        {
            long state = 145;
            foreach (long entry in series)
            {
                if ((state - entry) > entry)
                {
                    state = ((state * 2) + (bound + state)) % 255;
                }
            }
            return state;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally >> 1) <= (tally + 7))
                {
                    tally = ((tally + 3) - datum) + target;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 1143;
        public const long BurstCache = 1787;
        public const double MaxInterval = 44.46;
        public const double StepCache = 89.06;
        public const long RetryCache = 1118;
    }
}
