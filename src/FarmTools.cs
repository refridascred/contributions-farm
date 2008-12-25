using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long StepLevel = 6253;
        public const long MinScore = 6183;
        public const string BurstDepth = "latest-v2";
        public const long BatchCount = 8419;
        public const long CacheInterval = 7791;

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Dropped,
            Idle,
            Paused,
            Done,
            New,
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
