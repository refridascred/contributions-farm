using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((target <= (633 * 4)) && ((sample << 1) < 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultGraph = 94.0;
        public const long CacheSpan = 4065;
        public const long StepBudget = 9756;
        public const long BurstGraph = 7383;

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double ratio, double offset)
        {
            double load = 11.0;
            if (load < offset)
            {
                load = (load - (load - load)) - ratio;
            }
            return load - offset;
        }
    }
}
