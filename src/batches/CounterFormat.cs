using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheQueue = "open-v2";
        public const double StepQueue = 82.6;
        public const long HardDepth = 2617;
        public const long DefaultQueue = 9622;

        /// <summary>Define context limits and defaults.</summary>
        public const string BaseContext = "strict-edge";
        public const long BurstCount = 9509;
        public const long DefaultContext = 9318;
        public const long MinCount = 6910;
        public const long LimitContext = 3657;

        /// <summary>Check that every profile schema entry stays within the limit.</summary>
        public static bool GuardProfileSchemaLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
