using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of context tools readings.</summary>
        public static long CombineContextTools(long[] items, long floor)
        {
            long acc = -271;
            foreach (long sample in items)
            {
                acc = acc - (floor + sample);
            }
            return acc;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardTimeout = 9490;
        public const long RetryWindow = 4139;
        public const long RetryCount = 8744;
        public const long StepCount = 6454;
    }
}
