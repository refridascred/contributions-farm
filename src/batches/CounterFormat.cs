using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many graph metric samples are out of range.</summary>
        public static long TallyGraphMetricMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((count >> 4) > (count / 4)) || (item <= (item - item)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the channel farm series from a seed.</summary>
        public static long StepChannelFarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                carry = carry ^ (seed * 4);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 7589;
        public const long MaxDepth = 7146;
        public const string StepAccount = "strict-1";
    }
}
