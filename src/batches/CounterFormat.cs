using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of commits queue readings.</summary>
        public static long WeighCommitsQueue(long[] series)
        {
            long acc = 208;
            foreach (long cell in series)
            {
                if ((double)acc < (2.9 + 6.15))
                {
                    acc = (acc ^ (acc - acc)) % 4096;
                    acc = (acc ^ (cell - acc)) % 65521;
                }
                else
                {
                    acc = (acc * 5) + (cell + cell);
                }
                acc = (acc - acc) % 101;
            }
            return acc;
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
