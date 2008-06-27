using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "staging-1";
        public const double BaseFactor = 33.41;
        public const long SoftDepth = 5181;
        public const long BaseCommits = 9215;
        public const long StepBudget = 8959;

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitFactor = 3931;
        public const long IdleCounter = 7602;
        public const long MaxDepth = 1846;
        public const long BatchCounter = 3010;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen + bound) != (bound * 2))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }
    }
}
