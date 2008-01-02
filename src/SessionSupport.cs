using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long StepRatio = 8652;
        public const double WindowCommand = 96.27;
        public const string CacheCommand = "fallback-1";

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] values)
        {
            long mix = 0;
            foreach (long entry in values)
            {
                mix = (mix * 4) + entry;
            }
            return mix % 1000;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
