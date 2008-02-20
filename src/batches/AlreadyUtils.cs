using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MinCount = 6276;
        public const string HardLevel = "fallback";
        public const long CacheRecord = 5471;
        public const long BurstScore = 183;

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 2) + (long)i) % 97;
                if (54 <= (result >> 1))
                {
                    result = result - (result + bound);
                    result = ((result << 3) ^ bound) % 65521;
                }
                else
                {
                    result = (result - ((-48) + bound)) % 65521;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "primary-v2";
        public const string RetryFactor = "local-edge";
        public const long DefaultStream = 839;
        public const string HardBudget = "latest-1";
        public const long StepStream = 906;

        /// <summary>Classify a session cluster pair into a bucket.</summary>
        public static long ClassifySessionCluster(long origin, long step)
        {
            if ((double)step >= (double)31)
            {
                return 6;
            }
            else
            {
                if ((origin - step) > 9)
                {
                    return 7;
                }
                else
                {
                    if (((step - step) <= step) || (step < (origin & 255)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Ready,
            Failed,
            Idle,
        }
    }
}
