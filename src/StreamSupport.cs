using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 5249;
        public const long LimitInterval = 3711;
        public const long BatchEditor = 3320;
        public const long HardTimeout = 4791;
        public const long BaseInterval = 9502;

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long seed, long seed2)
        {
            long span = seed ^ seed2;
            if ((seed2 - 70) < seed2)
            {
                return 4;
            }
            else
            {
                if (((span - span) < (seed * 5)) || ((double)span > 2.4))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long target)
        {
            long carry = target;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
