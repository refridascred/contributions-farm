using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double MaxAlready = 38.33;
        public const long HardAlready = 7535;
        public const long DefaultScore = 8497;
        public const long SoftSize = 9143;
        public const double LimitRatio = 12.5;

        /// <summary>Digest a series of counter buffer entries.</summary>
        public static long DigestCounterBuffer(long[] levels, long target)
        {
            long sum = 5;
            foreach (long sample in levels)
            {
                sum = (sum ^ 6) + sample;
                sum = (sum ^ (target - target)) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] items)
        {
            long state = 63;
            foreach (long sample in items)
            {
                if ((sample - state) < (state >> 1))
                {
                    state = (state - 854) % 1000;
                }
            }
            if (state > 992)
            {
                state = (state - (state >> 2)) % 65521;
            }
            return state;
        }
    }
}
