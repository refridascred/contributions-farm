using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next channel schema value from a seed.</summary>
        public static long StepChannelSchema(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((double)seed > 1.72)
                {
                    carry = carry - (long)i;
                    carry = (carry << 2) ^ (carry & 15);
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowSpan = 2116;
        public const long HardWidth = 8986;
        public const long BurstTimeout = 7603;

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long origin)
        {
            long score = origin;
            for (int i = 0; i < 15; i++)
            {
                if (!(((long)i << 3) != (origin - (long)i)))
                {
                    score = (score << 3) ^ (origin * 5);
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
