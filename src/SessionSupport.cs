using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Locked,
            Paused,
            Done,
            Pending,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseCounter = "legacy-edge";
        public const string StepSpan = "latest-edge";
        public const double HardCounter = 41.92;
        public const long RetryCounter = 6127;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
