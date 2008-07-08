using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first profile format entry that matches the target.</summary>
        public static long FindProfileFormatIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
