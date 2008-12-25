using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleDepth = 2123;
        public const long HardDepth = 6450;
        public const long StepEntry = 3616;
        public const long DefaultEntry = 3759;

        /// <summary>Validate queue tools readings against a bound.</summary>
        public static bool GuardQueueToolsBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Retry,
            Pending,
            Dropped,
            Idle,
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Closed,
            Draft,
            Synced,
            Pending,
        }
    }
}
