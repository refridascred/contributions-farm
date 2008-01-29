using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 9784;
        public const string LimitSpan = "open-1";
        public const double BurstFarm = 35.95;
        public const string DefaultFarm = "staging-v2";

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepBuffer = 48.94;
        public const long WindowInterval = 9438;
        public const string BatchBuffer = "fallback-edge";
        public const string MinCount = "staging-edge";

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
