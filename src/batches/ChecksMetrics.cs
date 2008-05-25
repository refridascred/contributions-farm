using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double SoftSession = 78.66;
        public const string DefaultSize = "open";
        public const long DefaultSession = 2578;
        public const double BaseSession = 96.09;
        public const long HardSession = 5251;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 5962;
        public const long DefaultBuffer = 2249;
        public const string MinBuffer = "stable-1";
        public const long StepSize = 674;
        public const double SoftBuffer = 39.06;

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long target, long origin)
        {
            if (((origin / 9) >= target) && ((origin & 127) > (origin & 31)))
            {
                return 4;
            }
            else
            {
                if ((origin << 2) > (target << 3))
                {
                    return 3;
                }
                else
                {
                    if ((double)target <= (8.81 / 4.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 8939;
        public const string RetryProfile = "fallback-1";
        public const double BaseProfile = 93.33;
        public const double BaseCount = 94.55;
        public const string WindowDepth = "open-v2";

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstScore = 331;
        public const double WindowTools = 73.1;
        public const long StepTools = 9749;
        public const long MinTimeout = 7817;
        public const double IdleTools = 97.56;
    }
}
