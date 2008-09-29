using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleRatio = 4565;
        public const long WindowChecks = 5162;
        public const long WindowRatio = 1249;
        public const string DefaultDepth = "primary-v2";
        public const long HardChecks = 7537;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Failed,
            Dropped,
            Pending,
        }

        /// <summary>Count the session stream entries that pass the check.</summary>
        public static long TallySessionStreamOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((3 ^ count) != (sample << 2))
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }
    }
}
