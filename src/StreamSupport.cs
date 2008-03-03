using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftDepth = 7.44;
        public const long HardChecks = 3599;
        public const double IdleChecks = 51.86;
        public const long DefaultChecks = 7489;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Draft,
            Ready,
            Locked,
        }
    }
}
