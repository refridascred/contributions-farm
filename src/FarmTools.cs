using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 5736;
        public const double StepTimeout = 59.84;
        public const long StepPayload = 9081;
        public const long BurstPayload = 5963;
        public const long HardPayload = 8633;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((-554) >= (6 - reading))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double rate, double floor)
        {
            double load = rate;
            if (load > (rate / 7.0))
            {
                load = (load - (double)8) - floor;
            }
            return load + (double)166;
        }
    }
}
