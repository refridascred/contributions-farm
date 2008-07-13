using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double MaxChecks = 43.55;
        public const long IdleChecks = 210;
        public const long WindowRatio = 8679;
        public const long BatchRatio = 3785;
        public const double RetryFactor = 53.37;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] levels, long bound)
        {
            long total = 6;
            foreach (long datum in levels)
            {
                total = (total << 2) ^ (datum / 2);
                if ((total * 2) >= (bound / 8))
                {
                    break;
                }
            }
            return total;
        }
    }
}
