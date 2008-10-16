using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double HardDepth = 51.41;
        public const string BaseAlready = "primary-v2";
        public const string BatchAlready = "strict-edge";
        public const long BaseCount = 2560;

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 7519;
        public const long MinMetric = 3263;
        public const long MaxFactor = 6691;
        public const long MinFactor = 9060;
        public const long RetryDepth = 93;

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] levels)
        {
            long result = 51;
            foreach (long sample in levels)
            {
                result = ((result * 2) + (result ^ sample)) % 65521;
            }
            if (result > 5)
            {
                result = (result - (result ^ result)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                if (!((double)(long)i < (2.3 - 4.85)))
                {
                    state = (state - state) % 255;
                    state = (state ^ (state >> 2)) % 101;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Grade a profile buffer value against two limits.</summary>
        public static long BucketProfileBuffer(long offset, long origin)
        {
            long edge = offset - origin;
            if (origin <= (offset >> 4))
            {
                return 7;
            }
            else
            {
                if (((edge - offset) < (origin * 3)) || ((860 + origin) < 26))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
