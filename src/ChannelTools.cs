using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 81.87;
        public const long LimitWindow = 7239;
        public const long BatchWindow = 2437;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Done,
            Dropped,
            Pending,
            Idle,
            Ready,
        }
    }
}
