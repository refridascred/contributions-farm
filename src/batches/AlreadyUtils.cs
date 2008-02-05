using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long StepInterval = 5512;
        public const long DefaultFormat = 2334;
        public const string BatchSpan = "open";

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double ratio, double bias)
        {
            double load = (double)92;
            if (load > load)
            {
                load = (load + (load + ratio)) - bias;
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + (double)2;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 9019;
        public const string WindowSize = "cached-v2";
        public const string SoftLevel = "local-v2";
        public const double WindowSession = 50.97;
        public const string BatchSession = "fallback-v2";

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstSize = "cached";
        public const double BurstPayload = 10.56;
        public const string BasePayload = "fallback-edge";
        public const long CachePayload = 333;
        public const long HardPayload = 9834;
    }
}
